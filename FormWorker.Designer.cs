namespace PracticeApp
{
    partial class FormWorker
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelQualification = new System.Windows.Forms.Label();
            this.textQualification = new System.Windows.Forms.TextBox();
            this.labelProfession = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.textPatronymic = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelLastname = new System.Windows.Forms.Label();
            this.textLastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textProfession = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonExit.Location = new System.Drawing.Point(376, 387);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(160, 60);
            this.buttonExit.TabIndex = 26;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.Lime;
            this.buttonEnter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEnter.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEnter.Location = new System.Drawing.Point(183, 387);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(170, 60);
            this.buttonEnter.TabIndex = 25;
            this.buttonEnter.Text = "Подтвердить";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // labelQualification
            // 
            this.labelQualification.AutoSize = true;
            this.labelQualification.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQualification.Location = new System.Drawing.Point(12, 280);
            this.labelQualification.Name = "labelQualification";
            this.labelQualification.Size = new System.Drawing.Size(244, 30);
            this.labelQualification.TabIndex = 24;
            this.labelQualification.Text = "Уровень квалификации:";
            // 
            // textQualification
            // 
            this.textQualification.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textQualification.Location = new System.Drawing.Point(361, 277);
            this.textQualification.Name = "textQualification";
            this.textQualification.Size = new System.Drawing.Size(331, 35);
            this.textQualification.TabIndex = 23;
            // 
            // labelProfession
            // 
            this.labelProfession.AutoSize = true;
            this.labelProfession.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProfession.Location = new System.Drawing.Point(12, 224);
            this.labelProfession.Name = "labelProfession";
            this.labelProfession.Size = new System.Drawing.Size(125, 30);
            this.labelProfession.TabIndex = 21;
            this.labelProfession.Text = "Профессия:";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPatronymic.Location = new System.Drawing.Point(12, 168);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(108, 30);
            this.labelPatronymic.TabIndex = 20;
            this.labelPatronymic.Text = "Отчество:";
            // 
            // textPatronymic
            // 
            this.textPatronymic.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textPatronymic.Location = new System.Drawing.Point(361, 165);
            this.textPatronymic.Name = "textPatronymic";
            this.textPatronymic.Size = new System.Drawing.Size(331, 35);
            this.textPatronymic.TabIndex = 19;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(12, 112);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 30);
            this.labelName.TabIndex = 18;
            this.labelName.Text = "Имя:";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textName.Location = new System.Drawing.Point(361, 109);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(331, 35);
            this.textName.TabIndex = 17;
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLastname.Location = new System.Drawing.Point(12, 56);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(105, 30);
            this.labelLastname.TabIndex = 16;
            this.labelLastname.Text = "Фамилия:";
            // 
            // textLastname
            // 
            this.textLastname.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textLastname.Location = new System.Drawing.Point(361, 53);
            this.textLastname.Name = "textLastname";
            this.textLastname.Size = new System.Drawing.Size(331, 35);
            this.textLastname.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(213, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Введите ваши данные:";
            // 
            // textProfession
            // 
            this.textProfession.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textProfession.Location = new System.Drawing.Point(361, 221);
            this.textProfession.Name = "textProfession";
            this.textProfession.Size = new System.Drawing.Size(331, 35);
            this.textProfession.TabIndex = 27;
            // 
            // FormWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 497);
            this.Controls.Add(this.textProfession);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelQualification);
            this.Controls.Add(this.textQualification);
            this.Controls.Add(this.labelProfession);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.textPatronymic);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.textLastname);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(746, 536);
            this.MinimumSize = new System.Drawing.Size(746, 536);
            this.Name = "FormWorker";
            this.Text = "FormWorker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonExit;
        private Button buttonEnter;
        private Label labelQualification;
        private TextBox textQualification;
        private Label labelProfession;
        private Label labelPatronymic;
        private TextBox textPatronymic;
        private Label labelName;
        private TextBox textName;
        private Label labelLastname;
        private TextBox textLastname;
        private Label label1;
        private TextBox textProfession;
    }
}