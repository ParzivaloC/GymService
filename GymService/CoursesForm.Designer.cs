using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymService
{
    partial class CoursesForm
    {
        private System.ComponentModel.IContainer components = null;
        private GroupBox gbTrain;
        private GroupBox gbNutrition;
        private GroupBox gbRecovery;
        private Button btnTrain;
        private Button btnNutrition;
        private Button btnRecovery;
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
            gbTrain = new GroupBox();
            btnTrain = new Button();
            gbNutrition = new GroupBox();
            btnNutrition = new Button();
            gbRecovery = new GroupBox();
            btnRecovery = new Button();
            btnBack = new Button();
            gbTrain.SuspendLayout();
            gbNutrition.SuspendLayout();
            gbRecovery.SuspendLayout();
            SuspendLayout();
            // 
            // gbTrain
            // 
            gbTrain.Controls.Add(btnTrain);
            gbTrain.Location = new Point(20, 20);
            gbTrain.Name = "gbTrain";
            gbTrain.Size = new Size(420, 80);
            gbTrain.TabIndex = 0;
            gbTrain.TabStop = false;
            gbTrain.Text = "План тренировок";
            // 
            // btnTrain
            // 
            btnTrain.Location = new Point(300, 30);
            btnTrain.Name = "btnTrain";
            btnTrain.Size = new Size(96, 29);
            btnTrain.TabIndex = 0;
            btnTrain.Tag = "Тренировки";
            btnTrain.Text = "Записаться";
            btnTrain.Click += btnCourse_Click;
            // 
            // gbNutrition
            // 
            gbNutrition.Controls.Add(btnNutrition);
            gbNutrition.Location = new Point(20, 120);
            gbNutrition.Name = "gbNutrition";
            gbNutrition.Size = new Size(420, 80);
            gbNutrition.TabIndex = 1;
            gbNutrition.TabStop = false;
            gbNutrition.Text = "План питания";
            // 
            // btnNutrition
            // 
            btnNutrition.Location = new Point(300, 30);
            btnNutrition.Name = "btnNutrition";
            btnNutrition.Size = new Size(96, 28);
            btnNutrition.TabIndex = 0;
            btnNutrition.Tag = "Питание";
            btnNutrition.Text = "Записаться";
            btnNutrition.Click += btnCourse_Click;
            // 
            // gbRecovery
            // 
            gbRecovery.Controls.Add(btnRecovery);
            gbRecovery.Location = new Point(20, 220);
            gbRecovery.Name = "gbRecovery";
            gbRecovery.Size = new Size(420, 80);
            gbRecovery.TabIndex = 2;
            gbRecovery.TabStop = false;
            gbRecovery.Text = "План восстановления";
            // 
            // btnRecovery
            // 
            btnRecovery.Location = new Point(300, 30);
            btnRecovery.Name = "btnRecovery";
            btnRecovery.Size = new Size(96, 28);
            btnRecovery.TabIndex = 0;
            btnRecovery.Tag = "Восстановление";
            btnRecovery.Text = "Записаться";
            btnRecovery.Click += btnCourse_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(20, 320);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(80, 30);
            btnBack.TabIndex = 3;
            btnBack.Text = "Назад";
            btnBack.Click += btnBack_Click;
            // 
            // CoursesForm
            // 
            ClientSize = new Size(460, 360);
            Controls.Add(gbTrain);
            Controls.Add(gbNutrition);
            Controls.Add(gbRecovery);
            Controls.Add(btnBack);
            Name = "CoursesForm";
            Text = "Курсы";
            gbTrain.ResumeLayout(false);
            gbNutrition.ResumeLayout(false);
            gbRecovery.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
