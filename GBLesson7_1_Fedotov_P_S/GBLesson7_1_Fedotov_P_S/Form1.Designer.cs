
namespace GBLesson7_1_Fedotov_P_S
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResetButton = new System.Windows.Forms.Button();
            this.IncreaseButton = new System.Windows.Forms.Button();
            this.GeminationButton = new System.Windows.Forms.Button();
            this.BakcButton = new System.Windows.Forms.Button();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.TaskLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.Location = new System.Drawing.Point(317, 12);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(175, 46);
            this.ResetButton.TabIndex = 0;
            this.ResetButton.Text = "Сброс";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // IncreaseButton
            // 
            this.IncreaseButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IncreaseButton.Location = new System.Drawing.Point(317, 87);
            this.IncreaseButton.Name = "IncreaseButton";
            this.IncreaseButton.Size = new System.Drawing.Size(175, 46);
            this.IncreaseButton.TabIndex = 1;
            this.IncreaseButton.Text = "+1";
            this.IncreaseButton.UseVisualStyleBackColor = true;
            // 
            // GeminationButton
            // 
            this.GeminationButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GeminationButton.Location = new System.Drawing.Point(317, 162);
            this.GeminationButton.Name = "GeminationButton";
            this.GeminationButton.Size = new System.Drawing.Size(175, 46);
            this.GeminationButton.TabIndex = 2;
            this.GeminationButton.Text = "*2";
            this.GeminationButton.UseVisualStyleBackColor = true;
            // 
            // BakcButton
            // 
            this.BakcButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BakcButton.Location = new System.Drawing.Point(317, 237);
            this.BakcButton.Name = "BakcButton";
            this.BakcButton.Size = new System.Drawing.Size(175, 46);
            this.BakcButton.TabIndex = 3;
            this.BakcButton.Text = "Вернуть";
            this.BakcButton.UseVisualStyleBackColor = true;
            // 
            // LabelNumber
            // 
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelNumber.Location = new System.Drawing.Point(21, 87);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(61, 25);
            this.LabelNumber.TabIndex = 4;
            this.LabelNumber.Text = "None";
            // 
            // TaskLabel
            // 
            this.TaskLabel.AutoSize = true;
            this.TaskLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TaskLabel.Location = new System.Drawing.Point(21, 13);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(271, 21);
            this.TaskLabel.TabIndex = 5;
            this.TaskLabel.Text = "Нажмите сброс для начала игры";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoLabel.Location = new System.Drawing.Point(21, 162);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(96, 25);
            this.InfoLabel.TabIndex = 6;
            this.InfoLabel.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 295);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.TaskLabel);
            this.Controls.Add(this.LabelNumber);
            this.Controls.Add(this.BakcButton);
            this.Controls.Add(this.GeminationButton);
            this.Controls.Add(this.IncreaseButton);
            this.Controls.Add(this.ResetButton);
            this.Name = "Form1";
            this.Text = "Удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button IncreaseButton;
        private System.Windows.Forms.Button GeminationButton;
        private System.Windows.Forms.Button BakcButton;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.Label TaskLabel;
        private System.Windows.Forms.Label InfoLabel;
    }
}

