namespace calculator
{
    partial class P_Reiteration
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCout = new System.Windows.Forms.Button();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonToWriten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(9, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "i";
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(46, 16);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(43, 20);
            this.TextBox.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(249, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(86, 43);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить n";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCout
            // 
            this.buttonCout.Location = new System.Drawing.Point(249, 61);
            this.buttonCout.Name = "buttonCout";
            this.buttonCout.Size = new System.Drawing.Size(86, 43);
            this.buttonCout.TabIndex = 6;
            this.buttonCout.Text = "Вывести n-ы";
            this.buttonCout.UseVisualStyleBackColor = true;
            this.buttonCout.Click += new System.EventHandler(this.buttonCout_Click);
            // 
            // RichTextBox
            // 
            this.RichTextBox.Location = new System.Drawing.Point(12, 73);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(218, 72);
            this.RichTextBox.TabIndex = 7;
            this.RichTextBox.Text = "";
            // 
            // buttonToWriten
            // 
            this.buttonToWriten.Location = new System.Drawing.Point(249, 110);
            this.buttonToWriten.Name = "buttonToWriten";
            this.buttonToWriten.Size = new System.Drawing.Size(86, 43);
            this.buttonToWriten.TabIndex = 8;
            this.buttonToWriten.Text = "Записать";
            this.buttonToWriten.UseVisualStyleBackColor = true;
            this.buttonToWriten.Click += new System.EventHandler(this.buttonToWriten_Click);
            // 
            // Preiteration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 157);
            this.Controls.Add(this.buttonToWriten);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCout);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.label2);
            this.Name = "Preiteration";
            this.Text = "Preiteration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCout;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.Button buttonToWriten;
    }
}