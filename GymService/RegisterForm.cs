using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using GymService.Models;
using GymService.Services;

namespace GymService
{
    public partial class RegisterForm : Form
    {
        private User _user = new User();
        private bool _isEdit = false;

        public RegisterForm()
        {
            InitializeComponent();
            cmbGender.Items.AddRange(new[] { "Мужской", "Женский", "Другой" });
            LoadIfExists();
        }

        private void LoadIfExists()
        {
            var u = UserStorage.LoadUser();
            if (u != null)
            {
                _user = u;
                _isEdit = true;
                txtFirst.Text = u.FirstName;
                txtLast.Text = u.LastName;
                txtMiddle.Text = u.MiddleName;
                numAge.Value = u.Age;
                cmbGender.SelectedItem = u.Gender;
                numHeight.Value = u.Height;
                numWeight.Value = u.Weight;
                txtPhone.Text = u.Phone;
                txtEmail.Text = u.Email;
                btnSave.Text = "Сохранить";
            }
            else
            {
                btnSave.Text = "Зарегистрироваться";
            }
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            // simple regex: something@something.domain
            return Regex.IsMatch(email.Trim(), @"^[^\s@]+@[^\s@]+\.[^\s@]+$");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // simple LINQ-based validation
            var fields = new[] {
                (Name: "Имя", Value: txtFirst.Text),
                (Name: "Фамилия", Value: txtLast.Text),
                (Name: "Email", Value: txtEmail.Text)
            };

            var empty = fields.Where(f => string.IsNullOrWhiteSpace(f.Value)).Select(f => f.Name).ToArray();
            if (empty.Any())
            {
                MessageBox.Show("Заполните обязательные поля: " + string.Join(", ", empty));
                return;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Введите корректный Email в формате example@mail.com");
                return;
            }

            _user.FirstName = txtFirst.Text.Trim();
            _user.LastName = txtLast.Text.Trim();
            _user.MiddleName = txtMiddle.Text.Trim();
            _user.Age = (int)numAge.Value;
            _user.Gender = cmbGender.SelectedItem?.ToString() ?? string.Empty;
            _user.Height = (int)numHeight.Value;
            _user.Weight = (int)numWeight.Value;
            _user.Phone = txtPhone.Text.Trim();
            _user.Email = txtEmail.Text.Trim();

            UserStorage.SaveUser(_user);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
