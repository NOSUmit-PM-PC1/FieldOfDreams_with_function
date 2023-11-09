namespace FieldOfDreams
{
    partial class FormGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTemplate = new System.Windows.Forms.Label();
            this.textBoxLetter = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTemplate
            // 
            this.labelTemplate.AutoSize = true;
            this.labelTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemplate.Location = new System.Drawing.Point(225, 79);
            this.labelTemplate.Name = "labelTemplate";
            this.labelTemplate.Size = new System.Drawing.Size(63, 82);
            this.labelTemplate.TabIndex = 0;
            this.labelTemplate.Text = "*";
            // 
            // textBoxLetter
            // 
            this.textBoxLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLetter.Location = new System.Drawing.Point(215, 183);
            this.textBoxLetter.Name = "textBoxLetter";
            this.textBoxLetter.Size = new System.Drawing.Size(100, 62);
            this.textBoxLetter.TabIndex = 1;
            this.textBoxLetter.Text = "а";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(402, 183);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(156, 62);
            this.buttonCheck.TabIndex = 2;
            this.buttonCheck.Text = "Проверить";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.textBoxLetter);
            this.Controls.Add(this.labelTemplate);
            this.Name = "FormGame";
            this.Text = "игра ПОЛЕ ЧУДЕС";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTemplate;
        private System.Windows.Forms.TextBox textBoxLetter;
        private System.Windows.Forms.Button buttonCheck;
    }
}

