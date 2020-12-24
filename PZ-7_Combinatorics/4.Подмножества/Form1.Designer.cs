namespace WindowsFormsApp2
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
            this.button1 = new System.Windows.Forms.Button();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonToWrite = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ответ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RichTextBox
            // 
            this.RichTextBox.Enabled = false;
            this.RichTextBox.Location = new System.Drawing.Point(12, 163);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.ReadOnly = true;
            this.RichTextBox.Size = new System.Drawing.Size(227, 76);
            this.RichTextBox.TabIndex = 2;
            this.RichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "чч.мм.сс.мс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Поле ввода элем множества(поштучно)";
            // 
            // buttonToWrite
            // 
            this.buttonToWrite.Location = new System.Drawing.Point(245, 25);
            this.buttonToWrite.Name = "buttonToWrite";
            this.buttonToWrite.Size = new System.Drawing.Size(82, 20);
            this.buttonToWrite.TabIndex = 12;
            this.buttonToWrite.Text = "Записать";
            this.buttonToWrite.UseVisualStyleBackColor = true;
            this.buttonToWrite.Click += new System.EventHandler(this.buttonToWrite_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Поле вывода множества";
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Enabled = false;
            this.RichTextBox1.Location = new System.Drawing.Point(12, 84);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.ReadOnly = true;
            this.RichTextBox1.Size = new System.Drawing.Size(227, 60);
            this.RichTextBox1.TabIndex = 14;
            this.RichTextBox1.Text = "";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(12, 25);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(227, 20);
            this.TextBox1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 251);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.RichTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonToWrite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Подмножества";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonToWrite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RichTextBox1;
        private System.Windows.Forms.TextBox TextBox1;
    }
}

