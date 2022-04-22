namespace PracticeApp
{
    partial class Names
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
            this.employerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.emploeeButton = new System.Windows.Forms.Button();
            this.managerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employerButton
            // 
            this.employerButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.employerButton.Location = new System.Drawing.Point(260, 72);
            this.employerButton.Name = "employerButton";
            this.employerButton.Size = new System.Drawing.Size(160, 50);
            this.employerButton.TabIndex = 4;
            this.employerButton.Text = "Работодатель";
            this.employerButton.UseVisualStyleBackColor = true;
            
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(228, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите вашу роль";
            
            // 
            // emploeeButton
            // 
            this.emploeeButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.emploeeButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emploeeButton.Location = new System.Drawing.Point(260, 145);
            this.emploeeButton.Name = "emploeeButton";
            this.emploeeButton.Size = new System.Drawing.Size(160, 50);
            this.emploeeButton.TabIndex = 6;
            this.emploeeButton.Text = "Работник";
            this.emploeeButton.UseVisualStyleBackColor = true;
            // 
            // managerButton
            // 
            this.managerButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.managerButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.managerButton.Location = new System.Drawing.Point(260, 217);
            this.managerButton.Name = "managerButton";
            this.managerButton.Size = new System.Drawing.Size(160, 50);
            this.managerButton.TabIndex = 7;
            this.managerButton.Text = "Менеджер";
            this.managerButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "(Не для общественного использования)\r\n";
            // 
            // Names
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.managerButton);
            this.Controls.Add(this.emploeeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employerButton);
            this.Name = "Names";
            this.Text = "Employment bureau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button employerButton;
        private Label label1;
        private Button emploeeButton;
        private Button managerButton;
        private Label label2;
    }
}