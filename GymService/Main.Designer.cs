using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymService
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;
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
            btnCourses = new Button();
            lblTitle = new Label();
            labelHero = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnClose = new Button();
            btnAccount = new Button();
            SuspendLayout();
            // 
            // btnCourses
            // 
            btnCourses.BackColor = Color.Chocolate;
            btnCourses.FlatStyle = FlatStyle.Flat;
            btnCourses.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            btnCourses.ForeColor = SystemColors.ButtonHighlight;
            btnCourses.Location = new Point(12, 400);
            btnCourses.Margin = new Padding(3, 2, 3, 2);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(233, 47);
            btnCourses.TabIndex = 3;
            btnCourses.Text = "Курсы";
            btnCourses.UseVisualStyleBackColor = false;
            btnCourses.Click += btnCourses_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(295, 65);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GymService";
            // 
            // labelHero
            // 
            labelHero.AutoSize = true;
            labelHero.Font = new Font("Arial Black", 20.25F, FontStyle.Bold);
            labelHero.ForeColor = Color.Chocolate;
            labelHero.Location = new Point(12, 115);
            labelHero.Margin = new Padding(0);
            labelHero.Name = "labelHero";
            labelHero.Size = new Size(82, 38);
            labelHero.TabIndex = 4;
            labelHero.Text = "Ваш";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 20.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(81, 115);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(297, 38);
            label1.TabIndex = 5;
            label1.Text = "Фитнес-помошник";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 20.25F, FontStyle.Bold);
            label2.Location = new Point(12, 152);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(71, 38);
            label2.TabIndex = 6;
            label2.Text = "для";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 20.25F, FontStyle.Bold);
            label3.Location = new Point(242, 152);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(36, 38);
            label3.TabIndex = 7;
            label3.Text = "и";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 20.25F, FontStyle.Bold);
            label4.ForeColor = Color.Chocolate;
            label4.Location = new Point(74, 152);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(193, 38);
            label4.TabIndex = 8;
            label4.Text = "тренировок";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 20.25F, FontStyle.Bold);
            label5.ForeColor = Color.Chocolate;
            label5.Location = new Point(12, 189);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(179, 38);
            label5.TabIndex = 9;
            label5.Text = "похудения";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.Chocolate;
            label6.Location = new Point(12, 273);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(487, 60);
            label6.TabIndex = 10;
            label6.Text = "Раскройте свою лучшую версию с\r\nнашим полным спектром фитнес-услуг";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Chocolate;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(12, 456);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(233, 43);
            btnClose.TabIndex = 11;
            btnClose.Text = "Закрыть";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.Chocolate;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            btnAccount.ForeColor = SystemColors.ButtonHighlight;
            btnAccount.Location = new Point(754, 9);
            btnAccount.Margin = new Padding(3, 2, 3, 2);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(168, 42);
            btnAccount.TabIndex = 12;
            btnAccount.Text = "Регистрация";
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(934, 511);
            Controls.Add(btnAccount);
            Controls.Add(btnClose);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelHero);
            Controls.Add(lblTitle);
            Controls.Add(btnCourses);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GymService";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelHero;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnClose;
        private Button btnAccount;
    }
}
