namespace IND_4
{
    partial class Part1
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
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPart2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Location = new System.Drawing.Point(181, 85);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(75, 49);
            this.buttonAnswer.TabIndex = 0;
            this.buttonAnswer.Text = "Ответ";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Enabled = false;
            this.RichTextBox1.Location = new System.Drawing.Point(12, 85);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.ReadOnly = true;
            this.RichTextBox1.Size = new System.Drawing.Size(163, 49);
            this.RichTextBox1.TabIndex = 3;
            this.RichTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "чч.мм.сс.мс";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(38, 46);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(137, 20);
            this.TextBox1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "n =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Часть 1";
            // 
            // buttonPart2
            // 
            this.buttonPart2.Location = new System.Drawing.Point(149, 5);
            this.buttonPart2.Name = "buttonPart2";
            this.buttonPart2.Size = new System.Drawing.Size(75, 20);
            this.buttonPart2.TabIndex = 26;
            this.buttonPart2.Text = "Часть 2";
            this.buttonPart2.UseVisualStyleBackColor = true;
            this.buttonPart2.Click += new System.EventHandler(this.buttonPart2_Click);
            // 
            // Part1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 143);
            this.Controls.Add(this.buttonPart2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RichTextBox1);
            this.Controls.Add(this.buttonAnswer);
            this.Name = "Part1";
            this.Text = "Part1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.RichTextBox RichTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonPart2;
    }
}

