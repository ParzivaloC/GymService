using System;
using System.Windows.Forms;
using GymService.Services;

namespace GymService
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            UpdateAccountButton();
        }

        private void UpdateAccountButton()
        {
            bool exists = UserStorage.UserExists();
            if (exists)
            {
                btnAccount.Text = "Мой профиль";
            }
            else
            {
                btnAccount.Text = "Регистрация";
            }
        }

        public void RefreshAccountButton()
        {
            UpdateAccountButton();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if (!UserStorage.UserExists())
            {
                this.Hide();
                RegisterForm registerForm = new RegisterForm();
                registerForm.ShowDialog();
                this.Show();
            }
            else
            {
                this.Hide();
                ProfileForm profileForm = new ProfileForm();
                profileForm.ShowDialog();
                this.Show();
            }
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            this.Hide();
            CoursesForm coursesForm = new CoursesForm();
            coursesForm.ShowDialog();
            this.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
