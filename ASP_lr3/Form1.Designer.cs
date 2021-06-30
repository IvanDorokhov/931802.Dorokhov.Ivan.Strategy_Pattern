namespace ASP_lr3
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.number_radioButton = new System.Windows.Forms.RadioButton();
            this.lower_radioButton = new System.Windows.Forms.RadioButton();
            this.upper_radioButton = new System.Windows.Forms.RadioButton();
            this.check_Button = new System.Windows.Forms.Button();
            this.input_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.upper_radioButton);
            this.groupBox1.Controls.Add(this.lower_radioButton);
            this.groupBox1.Controls.Add(this.number_radioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Что введено?";
            // 
            // number_radioButton
            // 
            this.number_radioButton.AutoSize = true;
            this.number_radioButton.Checked = true;
            this.number_radioButton.Location = new System.Drawing.Point(21, 47);
            this.number_radioButton.Name = "number_radioButton";
            this.number_radioButton.Size = new System.Drawing.Size(57, 17);
            this.number_radioButton.TabIndex = 0;
            this.number_radioButton.TabStop = true;
            this.number_radioButton.Text = "Число";
            this.number_radioButton.UseVisualStyleBackColor = true;
            // 
            // lower_radioButton
            // 
            this.lower_radioButton.AutoSize = true;
            this.lower_radioButton.Location = new System.Drawing.Point(104, 47);
            this.lower_radioButton.Name = "lower_radioButton";
            this.lower_radioButton.Size = new System.Drawing.Size(162, 17);
            this.lower_radioButton.TabIndex = 1;
            this.lower_radioButton.Text = "Строка в нижнем регистре";
            this.lower_radioButton.UseVisualStyleBackColor = true;
            // 
            // upper_radioButton
            // 
            this.upper_radioButton.AutoSize = true;
            this.upper_radioButton.Location = new System.Drawing.Point(292, 47);
            this.upper_radioButton.Name = "upper_radioButton";
            this.upper_radioButton.Size = new System.Drawing.Size(165, 17);
            this.upper_radioButton.TabIndex = 2;
            this.upper_radioButton.Text = "Строка в верхнем регистре";
            this.upper_radioButton.UseVisualStyleBackColor = true;
            // 
            // check_Button
            // 
            this.check_Button.Location = new System.Drawing.Point(15, 189);
            this.check_Button.Name = "check_Button";
            this.check_Button.Size = new System.Drawing.Size(98, 34);
            this.check_Button.TabIndex = 1;
            this.check_Button.Text = "Проверить";
            this.check_Button.UseVisualStyleBackColor = true;
            this.check_Button.Click += new System.EventHandler(this.check_Button_Click);
            // 
            // input_TextBox
            // 
            this.input_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.input_TextBox.Location = new System.Drawing.Point(12, 133);
            this.input_TextBox.Name = "input_TextBox";
            this.input_TextBox.Size = new System.Drawing.Size(505, 23);
            this.input_TextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 242);
            this.Controls.Add(this.input_TextBox);
            this.Controls.Add(this.check_Button);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "АПС ЛР №3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton upper_radioButton;
        private System.Windows.Forms.RadioButton lower_radioButton;
        private System.Windows.Forms.RadioButton number_radioButton;
        private System.Windows.Forms.Button check_Button;
        private System.Windows.Forms.TextBox input_TextBox;
    }
}

