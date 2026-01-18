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
            labelFIO = new Label();
            labelEMAIL = new Label();
            label2 = new Label();
            labelPHONNE = new Label();
            labelKURSES = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.BackColor = Color.Silver;
            lblName.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblName.Location = new Point(47, 49);
            lblName.Name = "lblName";
            lblName.Size = new Size(500, 60);
            lblName.TabIndex = 0;
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            lblEmail.BackColor = Color.Silver;
            lblEmail.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblEmail.Location = new Point(47, 154);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(500, 60);
            lblEmail.TabIndex = 1;
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPhone
            // 
            lblPhone.BackColor = Color.Silver;
            lblPhone.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblPhone.Location = new Point(47, 262);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(500, 60);
            lblPhone.TabIndex = 2;
            lblPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDetails
            // 
            lblDetails.BackColor = Color.Silver;
            lblDetails.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblDetails.Location = new Point(47, 370);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(500, 136);
            lblDetails.TabIndex = 3;
            lblDetails.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCourses
            // 
            lblCourses.BackColor = Color.Silver;
            lblCourses.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblCourses.Location = new Point(47, 563);
            lblCourses.Name = "lblCourses";
            lblCourses.Size = new Size(500, 56);
            lblCourses.TabIndex = 4;
            lblCourses.Text = "Нет записей";
            lblCourses.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Chocolate;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(47, 669);
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
            btnLogout.Location = new Point(222, 669);
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
            btnBack.Location = new Point(392, 669);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(155, 60);
            btnBack.TabIndex = 7;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // labelFIO
            // 
            labelFIO.AutoSize = true;
            labelFIO.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelFIO.Location = new Point(47, 19);
            labelFIO.Name = "labelFIO";
            labelFIO.Size = new Size(73, 30);
            labelFIO.TabIndex = 8;
            labelFIO.Text = "ФИО:";
            // 
            // labelEMAIL
            // 
            labelEMAIL.AutoSize = true;
            labelEMAIL.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelEMAIL.Location = new Point(47, 124);
            labelEMAIL.Name = "labelEMAIL";
            labelEMAIL.Size = new Size(76, 30);
            labelEMAIL.TabIndex = 9;
            labelEMAIL.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(47, 277);
            label2.Name = "label2";
            label2.Size = new Size(0, 30);
            label2.TabIndex = 10;
            // 
            // labelPHONNE
            // 
            labelPHONNE.AutoSize = true;
            labelPHONNE.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPHONNE.Location = new Point(47, 232);
            labelPHONNE.Name = "labelPHONNE";
            labelPHONNE.Size = new Size(202, 30);
            labelPHONNE.TabIndex = 11;
            labelPHONNE.Text = "Номер телефона:";
            // 
            // labelKURSES
            // 
            labelKURSES.AutoSize = true;
            labelKURSES.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelKURSES.Location = new Point(47, 340);
            labelKURSES.Name = "labelKURSES";
            labelKURSES.Size = new Size(169, 30);
            labelKURSES.TabIndex = 12;
            labelKURSES.Text = "Ваши данные:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(47, 533);
            label1.Name = "label1";
            label1.Size = new Size(152, 30);
            label1.TabIndex = 13;
            label1.Text = "Ваши курсы:";
            // 
            // ProfileForm
            // 
            ClientSize = new Size(634, 741);
            Controls.Add(label1);
            Controls.Add(labelKURSES);
            Controls.Add(labelPHONNE);
            Controls.Add(label2);
            Controls.Add(labelEMAIL);
            Controls.Add(labelFIO);
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
            PerformLayout();
        }

        private Label labelFIO;
        private Label labelEMAIL;
        private Label label2;
        private Label labelPHONNE;
        private Label labelKURSES;
        private Label label1;
    }
}