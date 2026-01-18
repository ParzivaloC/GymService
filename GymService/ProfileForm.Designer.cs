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
            lblName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblDetails = new Label();
            lblCourses = new Label();
            btnEdit = new Button();
            btnLogout = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.BackColor = Color.Silver;
            lblName.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblName.Location = new Point(41, 86);
            lblName.Name = "lblName";
            lblName.Size = new Size(500, 40);
            lblName.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.BackColor = Color.Silver;
            lblEmail.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblEmail.Location = new Point(41, 157);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(500, 40);
            lblEmail.TabIndex = 1;
            // 
            // lblPhone
            // 
            lblPhone.BackColor = Color.Silver;
            lblPhone.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblPhone.Location = new Point(41, 230);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(500, 40);
            lblPhone.TabIndex = 2;
            // 
            // lblDetails
            // 
            lblDetails.BackColor = Color.Silver;
            lblDetails.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblDetails.Location = new Point(41, 346);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(500, 131);
            lblDetails.TabIndex = 3;
            // 
            // lblCourses
            // 
            lblCourses.BackColor = Color.Silver;
            lblCourses.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblCourses.Location = new Point(47, 513);
            lblCourses.Name = "lblCourses";
            lblCourses.Size = new Size(500, 56);
            lblCourses.TabIndex = 4;
            lblCourses.Text = "Нет записей";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Chocolate;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(47, 639);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(155, 60);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Изменить";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Chocolate;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(222, 639);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(155, 60);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Выйти";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Chocolate;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(392, 639);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(155, 60);
            btnBack.TabIndex = 7;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ProfileForm
            // 
            ClientSize = new Size(627, 711);
            Controls.Add(btnBack);
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