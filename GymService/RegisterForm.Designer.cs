using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymService
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtFirst;
        private TextBox txtLast;
        private TextBox txtMiddle;
        private NumericUpDown numAge;
        private ComboBox cmbGender;
        private NumericUpDown numHeight;
        private NumericUpDown numWeight;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Button btnSave;
        private Button btnCancel;
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
            txtFirst = new TextBox();
            txtLast = new TextBox();
            txtMiddle = new TextBox();
            numAge = new NumericUpDown();
            cmbGender = new ComboBox();
            numHeight = new NumericUpDown();
            numWeight = new NumericUpDown();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWeight).BeginInit();
            SuspendLayout();
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(20, 20);
            txtFirst.Name = "txtFirst";
            txtFirst.PlaceholderText = "Имя";
            txtFirst.Size = new Size(200, 26);
            txtFirst.TabIndex = 0;
            // 
            // txtLast
            // 
            txtLast.Location = new Point(240, 20);
            txtLast.Name = "txtLast";
            txtLast.PlaceholderText = "Фамилия";
            txtLast.Size = new Size(200, 26);
            txtLast.TabIndex = 1;
            // 
            // txtMiddle
            // 
            txtMiddle.Location = new Point(20, 60);
            txtMiddle.Name = "txtMiddle";
            txtMiddle.PlaceholderText = "Отчество";
            txtMiddle.Size = new Size(200, 26);
            txtMiddle.TabIndex = 2;
            // 
            // numAge
            // 
            numAge.Location = new Point(240, 60);
            numAge.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAge.Name = "numAge";
            numAge.Size = new Size(120, 26);
            numAge.TabIndex = 3;
            numAge.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // cmbGender
            // 
            cmbGender.Location = new Point(20, 100);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(200, 27);
            cmbGender.TabIndex = 4;
            // 
            // numHeight
            // 
            numHeight.Location = new Point(240, 100);
            numHeight.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            numHeight.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            numHeight.Name = "numHeight";
            numHeight.Size = new Size(120, 26);
            numHeight.TabIndex = 5;
            numHeight.Value = new decimal(new int[] { 170, 0, 0, 0 });
            // 
            // numWeight
            // 
            numWeight.Location = new Point(20, 140);
            numWeight.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numWeight.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            numWeight.Name = "numWeight";
            numWeight.Size = new Size(120, 26);
            numWeight.TabIndex = 6;
            numWeight.Value = new decimal(new int[] { 70, 0, 0, 0 });
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(240, 140);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "+7...";
            txtPhone.Size = new Size(200, 26);
            txtPhone.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(20, 180);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(420, 26);
            txtEmail.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(20, 220);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 35);
            btnSave.TabIndex = 9;
            btnSave.Text = "Сохранить";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(160, 220);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 35);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Отмена";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(300, 220);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 35);
            btnBack.TabIndex = 11;
            btnBack.Text = "Назад";
            btnBack.Click += btnBack_Click;
            // 
            // RegisterForm
            // 
            ClientSize = new Size(460, 280);
            Controls.Add(txtFirst);
            Controls.Add(txtLast);
            Controls.Add(txtMiddle);
            Controls.Add(numAge);
            Controls.Add(cmbGender);
            Controls.Add(numHeight);
            Controls.Add(numWeight);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnBack);
            Name = "RegisterForm";
            Text = "Регистрация";
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}