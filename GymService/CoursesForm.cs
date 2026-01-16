using System;
using System.Windows.Forms;
using GymService.Services;
using GymService.Models;

namespace GymService
{
    public partial class CoursesForm : Form
    {
        public CoursesForm()
        {
            InitializeComponent();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var course = btn?.Tag?.ToString() ?? "Курс";

            var user = UserStorage.LoadUser();
            if (user == null)
            {
                using var r = new RegisterForm();
                if (r.ShowDialog() == DialogResult.OK)
                {
                    user = UserStorage.LoadUser();
                    if (user != null)
                    {
                        user.EnrolledCourses.Add(course);
                        UserStorage.SaveUser(user);
                        MessageBox.Show($"Вы успешно записались на курс «{course}»");
                    }
                }
                return;
            }

            // if already enrolled, don't add duplicate
            if (!user.EnrolledCourses.Contains(course))
            {
                user.EnrolledCourses.Add(course);
                UserStorage.SaveUser(user);
            }

            MessageBox.Show($"Вы успешно записались на курс «{course}»");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
