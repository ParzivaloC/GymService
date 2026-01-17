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
            lblName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblDetails = new Label();
            lblCourses = new Label();
            btnEdit = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lblName.Location = new Point(20, 38);
            lblName.Name = "lblName";
            lblName.Size = new Size(430, 40);
            lblName.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lblEmail.Location = new Point(20, 97);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(430, 40);
            lblEmail.TabIndex = 1;
            // 
            // lblPhone
            // 
            lblPhone.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lblPhone.Location = new Point(20, 155);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(430, 40);
            lblPhone.TabIndex = 2;
            // 
            // lblDetails
            // 
            lblDetails.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lblDetails.Location = new Point(20, 210);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(430, 40);
            lblDetails.TabIndex = 3;
            // 
            // lblCourses
            // 
            lblCourses.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lblCourses.Location = new Point(20, 277);
            lblCourses.Name = "lblCourses";
            lblCourses.Size = new Size(430, 50);
            lblCourses.TabIndex = 4;
            lblCourses.Text = "Нет записей";
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnEdit.Location = new Point(20, 403);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(145, 47);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Изменить";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnLogout.Location = new Point(308, 403);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(142, 47);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Выйти";
            btnLogout.Click += btnLogout_Click;
            // 
            // ProfileForm
            // 
            ClientSize = new Size(480, 510);
            Controls.Add(lblName);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblDetails);
            Controls.Add(lblCourses);
            Controls.Add(btnEdit);
            Controls.Add(btnLogout);
            Name = "ProfileForm";
            Text = "Профиль";
            ResumeLayout(false);
        }
    }
}