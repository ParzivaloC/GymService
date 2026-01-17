using System;
using System.Windows.Forms;

namespace GymService
{
    public partial class CourseDetailsForm : Form
    {
        public CourseDetailsForm(string title, string description, string[] bullets)
        {
            InitializeComponent();
            lblTitle.Text = title;
            txtDescription.Text = description;
            lstBullets.Items.AddRange(bullets);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            // forward to CoursesForm enrollment logic by setting DialogResult
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
