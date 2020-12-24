namespace PZ19_2
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.RichTextBox2 = new System.Windows.Forms.RichTextBox();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Журнал";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "чч.мм.сс.мс";
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Location = new System.Drawing.Point(567, 217);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(75, 61);
            this.buttonAnswer.TabIndex = 30;
            this.buttonAnswer.Text = "Ответ";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // RichTextBox2
            // 
            this.RichTextBox2.Location = new System.Drawing.Point(327, 56);
            this.RichTextBox2.Name = "RichTextBox2";
            this.RichTextBox2.Size = new System.Drawing.Size(315, 155);
            this.RichTextBox2.TabIndex = 29;
            this.RichTextBox2.Text = "";
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Location = new System.Drawing.Point(4, 56);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(317, 222);
            this.RichTextBox1.TabIndex = 28;
            this.RichTextBox1.Text = "";
            this.RichTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(98, 11);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 20);
            this.TextBox1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Кол-во вершин";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 287);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.RichTextBox2);
            this.Controls.Add(this.RichTextBox1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Number2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.RichTextBox RichTextBox2;
        private System.Windows.Forms.RichTextBox RichTextBox1;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Label label1;
    }
}

