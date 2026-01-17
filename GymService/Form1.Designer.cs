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
            btnRegister.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnRegister.Location = new Point(576, 101);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(185, 45);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Регистрация";
            btnRegister.Click += btnRegister_Click;
            // 
            // btnProfile
            // 
            btnProfile.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnProfile.Location = new Point(385, 101);
            btnProfile.Margin = new Padding(3, 2, 3, 2);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(185, 45);
            btnProfile.TabIndex = 2;
            btnProfile.Text = "Мой профиль";
            btnProfile.Click += btnProfile_Click;
            // 
            // btnCourses
            // 
            btnCourses.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnCourses.Location = new Point(35, 101);
            btnCourses.Margin = new Padding(3, 2, 3, 2);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(185, 45);
            btnCourses.TabIndex = 3;
            btnCourses.Text = "Курсы";
            btnCourses.Click += btnCourses_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(223, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(295, 65);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GymService";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 511);
            Controls.Add(lblTitle);
            Controls.Add(btnRegister);
            Controls.Add(btnProfile);
            Controls.Add(btnCourses);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main";
            Text = "GymService";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
