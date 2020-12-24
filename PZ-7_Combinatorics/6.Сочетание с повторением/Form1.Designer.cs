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
            this.TextBoxK = new System.Windows.Forms.TextBox();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonToWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ответ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RichTextBox
            // 
            this.RichTextBox.Enabled = false;
            this.RichTextBox.Location = new System.Drawing.Point(9, 179);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.ReadOnly = true;
            this.RichTextBox.Size = new System.Drawing.Size(227, 49);
            this.RichTextBox.TabIndex = 2;
            this.RichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "чч.мм.сс.мс";
            // 
            // TextBoxK
            // 
            this.TextBoxK.Location = new System.Drawing.Point(12, 61);
            this.TextBoxK.Name = "TextBoxK";
            this.TextBoxK.Size = new System.Drawing.Size(224, 20);
            this.TextBoxK.TabIndex = 6;
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Enabled = false;
            this.RichTextBox1.Location = new System.Drawing.Point(9, 100);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.ReadOnly = true;
            this.RichTextBox1.Size = new System.Drawing.Size(227, 60);
            this.RichTextBox1.TabIndex = 19;
            this.RichTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Поле вывода элем";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "По сколька";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(12, 22);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(224, 20);
            this.TextBox1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Поле ввода элем(поштучно)";
            // 
            // buttonToWrite
            // 
            this.buttonToWrite.Location = new System.Drawing.Point(241, 22);
            this.buttonToWrite.Name = "buttonToWrite";
            this.buttonToWrite.Size = new System.Drawing.Size(82, 20);
            this.buttonToWrite.TabIndex = 24;
            this.buttonToWrite.Text = "Записать";
            this.buttonToWrite.UseVisualStyleBackColor = true;
            this.buttonToWrite.Click += new System.EventHandler(this.buttonToWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 235);
            this.Controls.Add(this.buttonToWrite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RichTextBox1);
            this.Controls.Add(this.TextBoxK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Сочетание с повторением";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxK;
        private System.Windows.Forms.RichTextBox RichTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonToWrite;
    }
}

