namespace PracticeApp
{
    partial class FormEmployer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelActivityType = new System.Windows.Forms.Label();
            this.textActivity = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.labelNomer = new System.Windows.Forms.Label();
            this.maskedTextPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelVacancy = new System.Windows.Forms.Label();
            this.textVacancy = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(213, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите ваши данные:";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textName.Location = new System.Drawing.Point(361, 53);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(331, 35);
            this.textName.TabIndex = 1;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(12, 56);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(344, 30);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Название компании/организации:";
            // 
            // labelActivityType
            // 
            this.labelActivityType.AutoSize = true;
            this.labelActivityType.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelActivityType.Location = new System.Drawing.Point(12, 112);
            this.labelActivityType.Name = "labelActivityType";
            this.labelActivityType.Size = new System.Drawing.Size(189, 30);
            this.labelActivityType.TabIndex = 4;
            this.labelActivityType.Text = "Вид деятельности:";
            // 
            // textActivity
            // 
            this.textActivity.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textActivity.Location = new System.Drawing.Point(361, 109);
            this.textActivity.Name = "textActivity";
            this.textActivity.Size = new System.Drawing.Size(331, 35);
            this.textActivity.TabIndex = 3;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddress.Location = new System.Drawing.Point(12, 168);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(76, 30);
            this.labelAddress.TabIndex = 6;
            this.labelAddress.Text = "Адрес:";
            // 
            // textAddress
            // 
            this.textAddress.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textAddress.Location = new System.Drawing.Point(361, 165);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(331, 35);
            this.textAddress.TabIndex = 5;
            // 
            // labelNomer
            // 
            this.labelNomer.AutoSize = true;
            this.labelNomer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNomer.Location = new System.Drawing.Point(12, 224);
            this.labelNomer.Name = "labelNomer";
            this.labelNomer.Size = new System.Drawing.Size(180, 30);
            this.labelNomer.TabIndex = 8;
            this.labelNomer.Text = "Номер телефона:";
            // 
            // maskedTextPhoneNumber
            // 
            this.maskedTextPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextPhoneNumber.Location = new System.Drawing.Point(361, 221);
            this.maskedTextPhoneNumber.Mask = "+7 (999) 000-0000";
            this.maskedTextPhoneNumber.Name = "maskedTextPhoneNumber";
            this.maskedTextPhoneNumber.Size = new System.Drawing.Size(175, 35);
            this.maskedTextPhoneNumber.TabIndex = 9;
            // 
            // labelVacancy
            // 
            this.labelVacancy.AutoSize = true;
            this.labelVacancy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVacancy.Location = new System.Drawing.Point(12, 280);
            this.labelVacancy.Name = "labelVacancy";
            this.labelVacancy.Size = new System.Drawing.Size(107, 30);
            this.labelVacancy.TabIndex = 11;
            this.labelVacancy.Text = "Вакансия:";
            // 
            // textVacancy
            // 
            this.textVacancy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textVacancy.Location = new System.Drawing.Point(361, 277);
            this.textVacancy.Name = "textVacancy";
            this.textVacancy.Size = new System.Drawing.Size(331, 35);
            this.textVacancy.TabIndex = 10;
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.Lime;
            this.buttonEnter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEnter.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEnter.Location = new System.Drawing.Point(183, 387);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(170, 60);
            this.buttonEnter.TabIndex = 12;
            this.buttonEnter.Text = "Подтвердить";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonExit.Location = new System.Drawing.Point(376, 387);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(160, 60);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormEmployer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 497);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelVacancy);
            this.Controls.Add(this.textVacancy);
            this.Controls.Add(this.maskedTextPhoneNumber);
            this.Controls.Add(this.labelNomer);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.labelActivityType);
            this.Controls.Add(this.textActivity);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(746, 536);
            this.MinimumSize = new System.Drawing.Size(746, 536);
            this.Name = "FormEmployer";
            this.Text = "FormEmployer";
            this.Load += new System.EventHandler(this.FormEmployer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textName;
        private Label labelName;
        private Label labelActivityType;
        private TextBox textActivity;
        private Label labelAddress;
        private TextBox textAddress;
        private Label labelNomer;
        private MaskedTextBox maskedTextPhoneNumber;
        private Label labelVacancy;
        private TextBox textVacancy;
        private Button buttonEnter;
        private Button buttonExit;
    }
}