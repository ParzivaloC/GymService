using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymService
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnRegister;
        private Button btnProfile;
        private Button btnCourses;
        private Label lblTitle;

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
            btnRegister = new Button();
            btnProfile = new Button();
            btnCourses = new Button();
            lblTitle = new Label();

            SuspendLayout();

            // Main form size (set before computing positions)
            ClientSize = new Size(640, 200);

            // Title
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(196, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GymService";

            // Buttons - shared size and layout
            var btnWidth = 130;
            var btnHeight = 36;
            var gap = 24;
            var top = 80;
            var count = 3;
            var total = count * btnWidth + (count - 1) * gap;
            var startX = (ClientSize.Width - total) / 2;

            btnRegister.Size = new Size(btnWidth, btnHeight);
            btnRegister.Location = new Point(startX, top);
            btnRegister.Name = "btnRegister";
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Регистрация";
            btnRegister.Click += btnRegister_Click;
            btnRegister.Visible = true;

            btnProfile.Size = new Size(btnWidth, btnHeight);
            btnProfile.Location = new Point(startX + (btnWidth + gap) * 1, top);
            btnProfile.Name = "btnProfile";
            btnProfile.TabIndex = 2;
            btnProfile.Text = "Мой профиль";
            btnProfile.Click += btnProfile_Click;
            btnProfile.Visible = true;

            btnCourses.Size = new Size(btnWidth, btnHeight);
            btnCourses.Location = new Point(startX + (btnWidth + gap) * 2, top);
            btnCourses.Name = "btnCourses";
            btnCourses.TabIndex = 3;
            btnCourses.Text = "Курсы";
            btnCourses.Click += btnCourses_Click;
            btnCourses.Visible = true;

            // Main
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTitle);
            Controls.Add(btnRegister);
            Controls.Add(btnProfile);
            Controls.Add(btnCourses);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GymService";
            Load += Main_Load;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
