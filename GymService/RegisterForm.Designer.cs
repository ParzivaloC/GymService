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
            labelAge = new Label();
            labelWeight = new Label();
            labelHeight = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWeight).BeginInit();
            SuspendLayout();
            // 
            // txtFirst
            // 
            txtFirst.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtFirst.Location = new Point(78, 49);
            txtFirst.Name = "txtFirst";
            txtFirst.PlaceholderText = "Èìÿ";
            txtFirst.Size = new Size(338, 32);
            txtFirst.TabIndex = 0;
            // 
            // txtLast
            // 
            txtLast.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtLast.Location = new Point(78, 96);
            txtLast.Name = "txtLast";
            txtLast.PlaceholderText = "Ôàìèëèÿ";
            txtLast.Size = new Size(338, 32);
            txtLast.TabIndex = 1;
            // 
            // txtMiddle
            // 
            txtMiddle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtMiddle.Location = new Point(78, 146);
            txtMiddle.Name = "txtMiddle";
            txtMiddle.PlaceholderText = "Îò÷åñòâî";
            txtMiddle.Size = new Size(338, 32);
            txtMiddle.TabIndex = 2;
            // 
            // numAge
            // 
            numAge.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            numAge.Location = new Point(275, 209);
            numAge.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAge.Name = "numAge";
            numAge.Size = new Size(141, 33);
            numAge.TabIndex = 3;
            numAge.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            cmbGender.Location = new Point(216, 374);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(200, 33);
            cmbGender.TabIndex = 4;
            // 
            // numHeight
            // 
            numHeight.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            numHeight.Location = new Point(275, 261);
            numHeight.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            numHeight.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            numHeight.Name = "numHeight";
            numHeight.Size = new Size(141, 33);
            numHeight.TabIndex = 5;
            numHeight.Value = new decimal(new int[] { 170, 0, 0, 0 });
            // 
            // numWeight
            // 
            numWeight.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            numWeight.Location = new Point(275, 317);
            numWeight.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numWeight.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            numWeight.Name = "numWeight";
            numWeight.Size = new Size(141, 33);
            numWeight.TabIndex = 6;
            numWeight.Value = new decimal(new int[] { 70, 0, 0, 0 });
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtPhone.Location = new Point(78, 427);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "+7...";
            txtPhone.Size = new Size(338, 33);
            txtPhone.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            txtEmail.Location = new Point(78, 481);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(338, 33);
            txtEmail.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnSave.Location = new Point(78, 579);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(161, 59);
            btnSave.TabIndex = 9;
            btnSave.Text = "Ñîõðàíèòü";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnCancel.Location = new Point(255, 579);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(161, 59);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Îòìåíà";
            btnCancel.Click += btnCancel_Click;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAge.Location = new Point(78, 211);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(86, 25);
            labelAge.TabIndex = 11;
            labelAge.Text = "Âîçðàñò:";
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelWeight.Location = new Point(78, 263);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(77, 25);
            labelWeight.TabIndex = 12;
            labelWeight.Text = "Âåñ(êã):";
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelHeight.Location = new Point(78, 319);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(90, 25);
            labelHeight.TabIndex = 13;
            labelHeight.Text = "Ðîñò(ñì):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(78, 377);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 14;
            label1.Text = "Ïîë:";
            // 
            // RegisterForm
            // 
            ClientSize = new Size(547, 661);
            Controls.Add(label1);
            Controls.Add(labelHeight);
            Controls.Add(labelWeight);
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
            Name = "RegisterForm";
            Text = "Ðåãèñòðàöèÿ";
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelAge;
        private Label labelWeight;
        private Label labelHeight;
        private Label label1;
    }
}
