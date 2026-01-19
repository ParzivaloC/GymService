using System;
using System.Linq;
using System.Windows.Forms;
using GymService.Services;

namespace GymService
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
            LoadProfile();
        }

        private void LoadProfile()
        {
            var user = UserStorage.LoadUser();
            if (user == null)
            {
                MessageBox.Show("Пользователь не найден");
                Close();
                return;
            }

            lblName.Text = $"{user.FirstName} {user.LastName}";
            lblEmail.Text = user.Email;
            lblPhone.Text = user.Phone;

            lblDetails.Text = string.Join('\n',
                $"Возраст: {user.Age}",
                $"Пол: {user.Gender}",
                $"Рост: {user.Height}",
                $"Вес: {user.Weight}"
            );

            lblCourses.Text = user.EnrolledCourses != null && user.EnrolledCourses.Count > 0
                ? string.Join(", ", user.EnrolledCourses)
                : "Нет записей";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            var res = registerForm.ShowDialog();
            this.Show();

            if (res == DialogResult.OK)
            {
                LoadProfile();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var ok = MessageBox.Show("Выйти и удалить профиль?", "Выйти", MessageBoxButtons.YesNo);
            if (ok == DialogResult.Yes)
            {
                UserStorage.DeleteUser();
                Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
