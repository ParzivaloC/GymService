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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new Label();
            this.txtDescription = new TextBox();
            this.lstBullets = new ListBox();
            this.btnEnroll = new Button();
            this.btnClose = new Button();

            SuspendLayout();

            this.lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Size = new Size(420, 30);

            this.txtDescription.Location = new Point(20, 60);
            this.txtDescription.Size = new Size(420, 80);
            this.txtDescription.Multiline = true;
            this.txtDescription.ReadOnly = true;

            this.lstBullets.Location = new Point(20, 150);
            this.lstBullets.Size = new Size(420, 120);

            this.btnEnroll.Location = new Point(20, 280);
            this.btnEnroll.Size = new Size(140, 35);
            this.btnEnroll.Text = "Записаться на курс";
            this.btnEnroll.Click += new EventHandler(this.btnEnroll_Click);

            this.btnClose.Location = new Point(180, 280);
            this.btnClose.Size = new Size(140, 35);
            this.btnClose.Text = "Закрыть";
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            // add Back button for consistency
            var btnBack = new Button();
            btnBack.Location = new Point(340, 280);
            btnBack.Size = new Size(80, 35);
            btnBack.Text = "Назад";
            btnBack.Click += new EventHandler(this.btnClose_Click);
            this.Controls.Add(btnBack);

            this.ClientSize = new Size(460, 330);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lstBullets);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.btnClose);
            this.Text = "Подробнее";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
