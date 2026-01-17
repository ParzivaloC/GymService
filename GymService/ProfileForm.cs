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
            var u = UserStorage.LoadUser();
            if (u == null)
            {
                MessageBox.Show("Пользователь не найден");
                Close();
                return;
            }

            lblName.Text = $"{u.FirstName} {u.LastName}";
            lblEmail.Text = u.Email;
            lblPhone.Text = u.Phone;
            lblDetails.Text = $"Возраст: {u.Age}, Пол: {u.Gender}, Рост: {u.Height}, Вес: {u.Weight}";

            // show enrolled courses
            if (u.EnrolledCourses != null && u.EnrolledCourses.Any())
            {
                lblCourses.Text = string.Join(", ", u.EnrolledCourses);
            }
            else
            {
                lblCourses.Text = "Нет записей";
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using var r = new RegisterForm();
            if (r.ShowDialog() == DialogResult.OK)
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
