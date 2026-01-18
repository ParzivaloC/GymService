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

        public RegisterForm()
        {
            InitializeComponent();
            LoadIfExists();

            //обрабтчики KeyPress
            txtFirst.KeyPress += Name_KeyPress;
            txtLast.KeyPress += Name_KeyPress;
            txtMiddle.KeyPress += Name_KeyPress;
            txtPhone.KeyPress += Phone_KeyPress;
        }

        private void LoadIfExists()
        {
            User user = UserStorage.LoadUser();
            if (user == null)
            {
                btnSave.Text = "Зарегистрироваться";
                return;
            }

            _user = user;

            txtFirst.Text = user.FirstName;
            txtLast.Text = user.LastName;
            txtMiddle.Text = user.MiddleName;
            numAge.Value = user.Age > 0 ? user.Age : 18;
            cmbGender.SelectedItem = user.Gender;
            numHeight.Value = user.Height > 0 ? user.Height : 170;
            numWeight.Value = user.Weight > 0 ? user.Weight : 70;
            txtPhone.Text = user.Phone;
            txtEmail.Text = user.Email;

            btnSave.Text = "Сохранить";
        }

        private void Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == '-')
                return;
            e.Handled = true;
        }

        private void Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) 
                return;
            if (char.IsDigit(e.KeyChar))
                return;
            e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var required = new[]//массив кортежей
            {
                ("Имя", txtFirst.Text),
                ("Фамилия", txtLast.Text),
                ("Email", txtEmail.Text)
            };

            var empty = required//массив незаполненных полей
                .Where(f => string.IsNullOrWhiteSpace(f.Item2))//f-один эл массива required
                .Select(f => f.Item1)
                .ToArray();

            if (empty.Any())//есть ли хоть один элемент в массиве
            {
                MessageBox.Show("Заполните поля: " + string.Join(", ", empty));
                return;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^\s@]+@[^\s@]+\.[^\s@]+$"))//Regex-класс для работы с регулярными выражениями
            {
                MessageBox.Show("Неверный формат Email");
                return;
            }

            if (!Regex.IsMatch(txtPhone.Text, @"^\d*$"))
            {
                MessageBox.Show("Номер телефона может содержать только цифры");
                return;
            }

            _user.FirstName = txtFirst.Text.Trim();
            _user.LastName = txtLast.Text.Trim();
            _user.MiddleName = txtMiddle.Text.Trim();
            _user.Age = (int)numAge.Value;
            _user.Gender = cmbGender.SelectedItem?.ToString() ?? "";
            _user.Height = (int)numHeight.Value;
            _user.Weight = (int)numWeight.Value;
            _user.Phone = txtPhone.Text.Trim();
            _user.Email = txtEmail.Text.Trim().ToLower();

            bool ok = UserStorage.SaveUser(_user);
            if (!ok)
            {
                MessageBox.Show("Ошибка сохранения");
                return;
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
