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
            labelAge = new Label();
            labelHeight = new Label();
            labelWeight = new Label();
            labelGender = new Label();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWeight).BeginInit();
            SuspendLayout();
            // 
            // txtFirst
            // 
            txtFirst.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtFirst.Location = new Point(34, 104);
            txtFirst.Name = "txtFirst";
            txtFirst.PlaceholderText = "Имя";
            txtFirst.Size = new Size(434, 38);
            txtFirst.TabIndex = 0;
            txtFirst.KeyPress += Name_KeyPress;
            // 
            // txtLast
            // 
            txtLast.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtLast.Location = new Point(34, 161);
            txtLast.Name = "txtLast";
            txtLast.PlaceholderText = "Фамилия";
            txtLast.Size = new Size(434, 38);
            txtLast.TabIndex = 1;
            txtLast.KeyPress += Name_KeyPress;
            // 
            // txtMiddle
            // 
            txtMiddle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtMiddle.Location = new Point(34, 217);
            txtMiddle.Name = "txtMiddle";
            txtMiddle.PlaceholderText = "Отчество";
            txtMiddle.Size = new Size(434, 38);
            txtMiddle.TabIndex = 2;
            txtMiddle.KeyPress += Name_KeyPress;
            // 
            // numAge
            // 
            numAge.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            numAge.Location = new Point(245, 278);
            numAge.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAge.Name = "numAge";
            numAge.Size = new Size(223, 38);
            numAge.TabIndex = 3;
            numAge.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            cmbGender.Items.AddRange(new object[] { "Мужчина", "Женщина", "Другой" });
            cmbGender.Location = new Point(245, 426);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(223, 39);
            cmbGender.TabIndex = 4;
            // 
            // numHeight
            // 
            numHeight.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            numHeight.Location = new Point(245, 328);
            numHeight.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            numHeight.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            numHeight.Name = "numHeight";
            numHeight.Size = new Size(223, 38);
            numHeight.TabIndex = 5;
            numHeight.Value = new decimal(new int[] { 170, 0, 0, 0 });
            // 
            // numWeight
            // 
            numWeight.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            numWeight.Location = new Point(245, 378);
            numWeight.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numWeight.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            numWeight.Name = "numWeight";
            numWeight.Size = new Size(223, 38);
            numWeight.TabIndex = 6;
            numWeight.Value = new decimal(new int[] { 70, 0, 0, 0 });
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtPhone.Location = new Point(34, 492);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "+7...";
            txtPhone.Size = new Size(434, 38);
            txtPhone.TabIndex = 7;
            txtPhone.KeyPress += Phone_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtEmail.Location = new Point(34, 546);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(434, 38);
            txtEmail.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Chocolate;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSave.Location = new Point(34, 612);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(195, 53);
            btnSave.TabIndex = 9;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Chocolate;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCancel.Location = new Point(273, 612);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(195, 53);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Chocolate;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(121, 36);
            btnBack.TabIndex = 11;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            labelAge.Location = new Point(34, 280);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(106, 31);
            labelAge.TabIndex = 12;
            labelAge.Text = "Возраст:";
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            labelHeight.Location = new Point(34, 330);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(111, 31);
            labelHeight.TabIndex = 13;
            labelHeight.Text = "Рост(см):";
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            labelWeight.Location = new Point(34, 380);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(94, 31);
            labelWeight.TabIndex = 14;
            labelWeight.Text = "Вес(кг):";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            labelGender.Location = new Point(34, 429);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(64, 31);
            labelGender.TabIndex = 15;
            labelGender.Text = "Пол:";
            // 
            // RegisterForm
            // 
            BackColor = Color.MistyRose;
            ClientSize = new Size(514, 691);
            Controls.Add(labelGender);
            Controls.Add(labelWeight);
            Controls.Add(labelHeight);
            Controls.Add(labelAge);
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

        private Label labelAge;
        private Label labelHeight;
        private Label labelWeight;
        private Label labelGender;
    }
}