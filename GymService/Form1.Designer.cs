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

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        // private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRegister = new Button();
            btnProfile = new Button();
            btnCourses = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(30, 80);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 35);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Регистрация";
            btnRegister.Click += btnRegister_Click;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(170, 80);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(120, 35);
            btnProfile.TabIndex = 2;
            btnProfile.Text = "Мой профиль";
            btnProfile.Click += btnProfile_Click;
            // 
            // btnCourses
            // 
            btnCourses.Location = new Point(310, 80);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(120, 35);
            btnCourses.TabIndex = 3;
            btnCourses.Text = "Курсы";
            btnCourses.Click += btnCourses_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(180, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GymService";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 392);
            Controls.Add(lblTitle);
            Controls.Add(btnRegister);
            Controls.Add(btnProfile);
            Controls.Add(btnCourses);
            Name = "Main";
            Text = "GymService";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
