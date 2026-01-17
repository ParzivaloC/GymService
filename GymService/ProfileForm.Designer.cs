using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymService
{
    partial class ProfileForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblDetails;
        private Label lblCourses;
        private Button btnEdit;
        private Button btnLogout;
        private Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblName = new Label();
            this.lblEmail = new Label();
            this.lblPhone = new Label();
            this.lblDetails = new Label();
            this.lblCourses = new Label();
            this.btnEdit = new Button();
            this.btnLogout = new Button();

            SuspendLayout();

            this.lblName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblName.Location = new Point(20, 20);
            this.lblName.Size = new Size(420, 30);

            this.lblEmail.Location = new Point(20, 60);
            this.lblEmail.Size = new Size(420, 23);

            this.lblPhone.Location = new Point(20, 90);
            this.lblPhone.Size = new Size(420, 23);

            this.lblDetails.Location = new Point(20, 120);
            this.lblDetails.Size = new Size(420, 23);

            this.lblCourses.Location = new Point(20, 150);
            this.lblCourses.Size = new Size(420, 40);
            this.lblCourses.Text = "Нет записей";

            this.btnEdit.Location = new Point(20, 200);
            this.btnEdit.Size = new Size(120, 35);
            this.btnEdit.Text = "Изменить";
            this.btnEdit.Click += new EventHandler(this.btnEdit_Click);

            this.btnLogout.Location = new Point(160, 200);
            this.btnLogout.Size = new Size(120, 35);
            this.btnLogout.Text = "Выйти";
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);

            this.btnBack.Location = new Point(300, 200);
            this.btnBack.Size = new Size(120, 35);
            this.btnBack.Text = "Назад";
            this.btnBack.Click += new EventHandler(this.btnLogout_Click);

            this.ClientSize = new Size(460, 260);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBack);
            this.Text = "Профиль";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
