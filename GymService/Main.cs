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
                RegisterForm registerForm = new RegisterForm();
                registerForm.FormClosed += ChildForm_FormClosed;
                this.Hide();
                registerForm.Show();
            }
            else
            {
                ProfileForm profileForm = new ProfileForm();
                profileForm.FormClosed += ChildForm_FormClosed;
                this.Hide();
                profileForm.Show();
            }
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            CoursesForm coursesForm = new CoursesForm();
            coursesForm.FormClosed += ChildForm_FormClosed;
            this.Hide();
            coursesForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();//показ Main
            UpdateAccountButton();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
