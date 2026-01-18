using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymService
{
    partial class CourseDetailsForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private TextBox txtDescription;
        private ListBox lstBullets;
        private Button btnEnroll;
        private Button btnClose;

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
            lblTitle = new Label();
            txtDescription = new TextBox();
            lstBullets = new ListBox();
            btnEnroll = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.Location = new Point(12, 100);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(510, 60);
            lblTitle.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtDescription.Location = new Point(12, 163);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(510, 150);
            txtDescription.TabIndex = 2;
            txtDescription.TextAlign = HorizontalAlignment.Center;
            // 
            // lstBullets
            // 
            lstBullets.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lstBullets.ItemHeight = 21;
            lstBullets.Location = new Point(12, 344);
            lstBullets.Name = "lstBullets";
            lstBullets.Size = new Size(510, 130);
            lstBullets.TabIndex = 3;
            // 
            // btnEnroll
            // 
            btnEnroll.BackColor = Color.Chocolate;
            btnEnroll.FlatStyle = FlatStyle.Flat;
            btnEnroll.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnEnroll.ForeColor = SystemColors.ButtonHighlight;
            btnEnroll.Location = new Point(12, 512);
            btnEnroll.Name = "btnEnroll";
            btnEnroll.Size = new Size(233, 43);
            btnEnroll.TabIndex = 4;
            btnEnroll.Text = "Записаться на курс";
            btnEnroll.UseVisualStyleBackColor = false;
            btnEnroll.Click += btnEnroll_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Chocolate;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(289, 512);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(233, 43);
            btnClose.TabIndex = 5;
            btnClose.Text = "Закрыть";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // CourseDetailsForm
            // 
            BackColor = Color.MistyRose;
            ClientSize = new Size(534, 580);
            Controls.Add(lblTitle);
            Controls.Add(txtDescription);
            Controls.Add(lstBullets);
            Controls.Add(btnEnroll);
            Controls.Add(btnClose);
            Name = "CourseDetailsForm";
            Text = "Подробнее";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
