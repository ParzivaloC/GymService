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
            gbTrain.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            gbTrain.Location = new Point(29, 153);
            gbTrain.Name = "gbTrain";
            gbTrain.Size = new Size(463, 80);
            gbTrain.TabIndex = 0;
            gbTrain.TabStop = false;
            gbTrain.Text = "План тренировок";
            // 
            // btnTrainDetails
            // 
            btnTrainDetails.BackColor = Color.Chocolate;
            btnTrainDetails.FlatStyle = FlatStyle.Flat;
            btnTrainDetails.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnTrainDetails.ForeColor = SystemColors.ButtonHighlight;
            btnTrainDetails.Location = new Point(192, 30);
            btnTrainDetails.Name = "btnTrainDetails";
            btnTrainDetails.Size = new Size(114, 33);
            btnTrainDetails.TabIndex = 0;
            btnTrainDetails.Tag = "Тренировки";
            btnTrainDetails.Text = "Подробнее";
            btnTrainDetails.UseVisualStyleBackColor = false;
            btnTrainDetails.Click += btnTrainDetails_Click;
            // 
            // btnTrain
            // 
            btnTrain.BackColor = Color.Chocolate;
            btnTrain.FlatStyle = FlatStyle.Flat;
            btnTrain.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnTrain.ForeColor = SystemColors.ButtonHighlight;
            btnTrain.Location = new Point(312, 30);
            btnTrain.Name = "btnTrain";
            btnTrain.Size = new Size(104, 33);
            btnTrain.TabIndex = 1;
            btnTrain.Tag = "Тренировки";
            btnTrain.Text = "Записаться";
            btnTrain.UseVisualStyleBackColor = false;
            btnTrain.Click += btnTrain_Click;
            // 
            // gbNutrition
            // 
            gbNutrition.Controls.Add(btnNutritionDetails);
            gbNutrition.Controls.Add(btnNutrition);
            gbNutrition.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            gbNutrition.Location = new Point(29, 253);
            gbNutrition.Name = "gbNutrition";
            gbNutrition.Size = new Size(463, 80);
            gbNutrition.TabIndex = 1;
            gbNutrition.TabStop = false;
            gbNutrition.Text = "План питания";
            // 
            // btnNutritionDetails
            // 
            btnNutritionDetails.BackColor = Color.Chocolate;
            btnNutritionDetails.FlatStyle = FlatStyle.Flat;
            btnNutritionDetails.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnNutritionDetails.ForeColor = SystemColors.ButtonHighlight;
            btnNutritionDetails.Location = new Point(192, 30);
            btnNutritionDetails.Name = "btnNutritionDetails";
            btnNutritionDetails.Size = new Size(114, 32);
            btnNutritionDetails.TabIndex = 0;
            btnNutritionDetails.Tag = "Питание";
            btnNutritionDetails.Text = "Подробнее";
            btnNutritionDetails.UseVisualStyleBackColor = false;
            btnNutritionDetails.Click += btnNutritionDetails_Click;
            // 
            // btnNutrition
            // 
            btnNutrition.BackColor = Color.Chocolate;
            btnNutrition.FlatStyle = FlatStyle.Flat;
            btnNutrition.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnNutrition.ForeColor = SystemColors.ButtonHighlight;
            btnNutrition.Location = new Point(312, 30);
            btnNutrition.Name = "btnNutrition";
            btnNutrition.Size = new Size(104, 32);
            btnNutrition.TabIndex = 1;
            btnNutrition.Tag = "Питание";
            btnNutrition.Text = "Записаться";
            btnNutrition.UseVisualStyleBackColor = false;
            btnNutrition.Click += btnNutrition_Click;
            // 
            // gbRecovery
            // 
            gbRecovery.Controls.Add(btnRecoveryDetails);
            gbRecovery.Controls.Add(btnRecovery);
            gbRecovery.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            gbRecovery.Location = new Point(29, 354);
            gbRecovery.Name = "gbRecovery";
            gbRecovery.Size = new Size(463, 79);
            gbRecovery.TabIndex = 2;
            gbRecovery.TabStop = false;
            gbRecovery.Text = "План восстановления";
            // 
            // btnRecoveryDetails
            // 
            btnRecoveryDetails.BackColor = Color.Chocolate;
            btnRecoveryDetails.FlatStyle = FlatStyle.Flat;
            btnRecoveryDetails.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnRecoveryDetails.ForeColor = SystemColors.ButtonHighlight;
            btnRecoveryDetails.Location = new Point(192, 30);
            btnRecoveryDetails.Name = "btnRecoveryDetails";
            btnRecoveryDetails.Size = new Size(114, 29);
            btnRecoveryDetails.TabIndex = 0;
            btnRecoveryDetails.Tag = "Восстановление";
            btnRecoveryDetails.Text = "Подробнее";
            btnRecoveryDetails.UseVisualStyleBackColor = false;
            btnRecoveryDetails.Click += btnRecoveryDetails_Click;
            // 
            // btnRecovery
            // 
            btnRecovery.BackColor = Color.Chocolate;
            btnRecovery.FlatStyle = FlatStyle.Flat;
            btnRecovery.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnRecovery.ForeColor = SystemColors.ButtonHighlight;
            btnRecovery.Location = new Point(312, 30);
            btnRecovery.Name = "btnRecovery";
            btnRecovery.Size = new Size(104, 29);
            btnRecovery.TabIndex = 1;
            btnRecovery.Tag = "Восстановление";
            btnRecovery.Text = "Записаться";
            btnRecovery.UseVisualStyleBackColor = false;
            btnRecovery.Click += btnRecovery_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Chocolate;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(127, 38);
            btnBack.TabIndex = 3;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // CoursesForm
            // 
            BackColor = Color.MistyRose;
            ClientSize = new Size(523, 462);
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
