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
            this.components = new System.ComponentModel.Container();
            this.txtFirst = new TextBox();
            this.txtLast = new TextBox();
            this.txtMiddle = new TextBox();
            this.numAge = new NumericUpDown();
            this.cmbGender = new ComboBox();
            this.numHeight = new NumericUpDown();
            this.numWeight = new NumericUpDown();
            this.txtPhone = new TextBox();
            this.txtEmail = new TextBox();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            this.btnBack = new Button();

            // Begin init for numeric controls
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            SuspendLayout();

            // controls layout (simple)
            this.txtFirst.PlaceholderText = "Имя";
            this.txtFirst.Location = new Point(20, 20);
            this.txtFirst.Size = new Size(200, 27);

            this.txtLast.PlaceholderText = "Фамилия";
            this.txtLast.Location = new Point(240, 20);
            this.txtLast.Size = new Size(200, 27);

            this.txtMiddle.PlaceholderText = "Отчество";
            this.txtMiddle.Location = new Point(20, 60);
            this.txtMiddle.Size = new Size(200, 27);

            this.numAge.Location = new Point(240, 60);
            this.numAge.Minimum = 1;
            this.numAge.Maximum = 120;
            this.numAge.Value = 18;

            this.cmbGender.Location = new Point(20, 100);
            this.cmbGender.Size = new Size(200, 27);

            this.numHeight.Location = new Point(240, 100);
            this.numHeight.Minimum = 50;
            this.numHeight.Maximum = 250;
            this.numHeight.Value = 170;

            this.numWeight.Location = new Point(20, 140);
            this.numWeight.Minimum = 20;
            this.numWeight.Maximum = 300;
            this.numWeight.Value = 70;

            this.txtPhone.PlaceholderText = "+7...";
            this.txtPhone.Location = new Point(240, 140);
            this.txtPhone.Size = new Size(200, 27);

            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Location = new Point(20, 180);
            this.txtEmail.Size = new Size(420, 27);

            this.btnSave.Location = new Point(20, 220);
            this.btnSave.Size = new Size(120, 35);
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            this.btnCancel.Location = new Point(160, 220);
            this.btnCancel.Size = new Size(120, 35);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

            this.btnBack.Location = new Point(300, 220);
            this.btnBack.Size = new Size(120, 35);
            this.btnBack.Text = "Назад";
            this.btnBack.Click += new EventHandler(this.btnBack_Click);

            this.ClientSize = new Size(460, 280);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtMiddle);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.numHeight);
            this.Controls.Add(this.numWeight);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBack);
            this.Text = "Регистрация";
            // End init for numeric controls
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
