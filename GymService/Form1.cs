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
            UpdateUi();
        }

        private void UpdateUi()
        {
            var exists = UserStorage.IsUserExists();
            btnRegister.Visible = !exists;
            btnProfile.Enabled = exists;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using var f = new RegisterForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                UpdateUi();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (!UserStorage.IsUserExists())
            {
                using var f = new RegisterForm();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    UpdateUi();
                }
                return;
            }

            using var p = new ProfileForm();
            p.ShowDialog();
            UpdateUi();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            using var c = new CoursesForm();
            c.ShowDialog();
        }
    }
}
