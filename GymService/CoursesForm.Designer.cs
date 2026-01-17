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
        private Button btnTrainDetails;
        private Button btnNutritionDetails;
        private Button btnRecoveryDetails;

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
            btnTrainDetails = new Button();
            btnTrain = new Button();
            gbNutrition = new GroupBox();
            btnNutritionDetails = new Button();
            btnNutrition = new Button();
            gbRecovery = new GroupBox();
            btnRecoveryDetails = new Button();
            btnRecovery = new Button();
            btnBack = new Button();
            gbTrain.SuspendLayout();
            gbNutrition.SuspendLayout();
            gbRecovery.SuspendLayout();
            SuspendLayout();
            // 
            // gbTrain
            // 
            gbTrain.Controls.Add(btnTrainDetails);
            gbTrain.Controls.Add(btnTrain);
            gbTrain.Location = new Point(20, 20);
            gbTrain.Name = "gbTrain";
            gbTrain.Size = new Size(420, 80);
            gbTrain.TabIndex = 0;
            gbTrain.TabStop = false;
            gbTrain.Text = "План тренировок";
            // 
            // btnTrainDetails
            // 
            btnTrainDetails.Location = new Point(192, 30);
            btnTrainDetails.Name = "btnTrainDetails";
            btnTrainDetails.Size = new Size(98, 33);
            btnTrainDetails.TabIndex = 0;
            btnTrainDetails.Tag = "Тренировки";
            btnTrainDetails.Text = "Подробнее";
            btnTrainDetails.Click += btnDetails_Click;
            // 
            // btnTrain
            // 
            btnTrain.Location = new Point(300, 30);
            btnTrain.Name = "btnTrain";
            btnTrain.Size = new Size(100, 33);
            btnTrain.TabIndex = 1;
            btnTrain.Tag = "Тренировки";
            btnTrain.Text = "Записаться";
            btnTrain.Click += btnCourse_Click;
            // 
            // gbNutrition
            // 
            gbNutrition.Controls.Add(btnNutritionDetails);
            gbNutrition.Controls.Add(btnNutrition);
            gbNutrition.Location = new Point(20, 120);
            gbNutrition.Name = "gbNutrition";
            gbNutrition.Size = new Size(420, 80);
            gbNutrition.TabIndex = 1;
            gbNutrition.TabStop = false;
            gbNutrition.Text = "План питания";
            // 
            // btnNutritionDetails
            // 
            btnNutritionDetails.Location = new Point(192, 30);
            btnNutritionDetails.Name = "btnNutritionDetails";
            btnNutritionDetails.Size = new Size(98, 32);
            btnNutritionDetails.TabIndex = 0;
            btnNutritionDetails.Tag = "Питание";
            btnNutritionDetails.Text = "Подробнее";
            btnNutritionDetails.Click += btnDetails_Click;
            // 
            // btnNutrition
            // 
            btnNutrition.Location = new Point(300, 30);
            btnNutrition.Name = "btnNutrition";
            btnNutrition.Size = new Size(100, 32);
            btnNutrition.TabIndex = 1;
            btnNutrition.Tag = "Питание";
            btnNutrition.Text = "Записаться";
            btnNutrition.Click += btnCourse_Click;
            // 
            // gbRecovery
            // 
            gbRecovery.Controls.Add(btnRecoveryDetails);
            gbRecovery.Controls.Add(btnRecovery);
            gbRecovery.Location = new Point(20, 220);
            gbRecovery.Name = "gbRecovery";
            gbRecovery.Size = new Size(420, 80);
            gbRecovery.TabIndex = 2;
            gbRecovery.TabStop = false;
            gbRecovery.Text = "План восстановления";
            // 
            // btnRecoveryDetails
            // 
            btnRecoveryDetails.Location = new Point(192, 30);
            btnRecoveryDetails.Name = "btnRecoveryDetails";
            btnRecoveryDetails.Size = new Size(98, 29);
            btnRecoveryDetails.TabIndex = 0;
            btnRecoveryDetails.Tag = "Восстановление";
            btnRecoveryDetails.Text = "Подробнее";
            btnRecoveryDetails.Click += btnDetails_Click;
            // 
            // btnRecovery
            // 
            btnRecovery.Location = new Point(300, 30);
            btnRecovery.Name = "btnRecovery";
            btnRecovery.Size = new Size(100, 29);
            btnRecovery.TabIndex = 1;
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
