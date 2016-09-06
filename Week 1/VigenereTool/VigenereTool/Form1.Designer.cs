namespace VigenereTool
{
    partial class Form1
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
            this.FeedbackTxtBox = new System.Windows.Forms.RichTextBox();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.keyTxtBox = new System.Windows.Forms.TextBox();
            this.keyLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.decryptFileBtn = new System.Windows.Forms.Button();
            this.correctKeyBtn = new System.Windows.Forms.Button();
            this.wrongKeyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FeedbackTxtBox
            // 
            this.FeedbackTxtBox.Location = new System.Drawing.Point(274, 209);
            this.FeedbackTxtBox.Name = "FeedbackTxtBox";
            this.FeedbackTxtBox.Size = new System.Drawing.Size(241, 237);
            this.FeedbackTxtBox.TabIndex = 0;
            this.FeedbackTxtBox.Text = "";
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(54, 135);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(95, 58);
            this.encryptBtn.TabIndex = 1;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(54, 209);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(95, 56);
            this.decryptBtn.TabIndex = 2;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(341, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 22);
            this.textBox1.TabIndex = 3;
            // 
            // keyTxtBox
            // 
            this.keyTxtBox.Location = new System.Drawing.Point(341, 112);
            this.keyTxtBox.Name = "keyTxtBox";
            this.keyTxtBox.Size = new System.Drawing.Size(174, 22);
            this.keyTxtBox.TabIndex = 4;
            // 
            // keyLbl
            // 
            this.keyLbl.AutoSize = true;
            this.keyLbl.Location = new System.Drawing.Point(299, 112);
            this.keyLbl.Name = "keyLbl";
            this.keyLbl.Size = new System.Drawing.Size(36, 17);
            this.keyLbl.TabIndex = 5;
            this.keyLbl.Text = "Key:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Word To Encrypt/Decrypt:";
            // 
            // decryptFileBtn
            // 
            this.decryptFileBtn.Location = new System.Drawing.Point(54, 284);
            this.decryptFileBtn.Name = "decryptFileBtn";
            this.decryptFileBtn.Size = new System.Drawing.Size(95, 56);
            this.decryptFileBtn.TabIndex = 7;
            this.decryptFileBtn.Text = "Decrypt File";
            this.decryptFileBtn.UseVisualStyleBackColor = true;
            this.decryptFileBtn.Click += new System.EventHandler(this.decryptFileBtn_Click);
            // 
            // correctKeyBtn
            // 
            this.correctKeyBtn.Location = new System.Drawing.Point(12, 364);
            this.correctKeyBtn.Name = "correctKeyBtn";
            this.correctKeyBtn.Size = new System.Drawing.Size(95, 56);
            this.correctKeyBtn.TabIndex = 8;
            this.correctKeyBtn.Text = "Correct Key";
            this.correctKeyBtn.UseVisualStyleBackColor = true;
            this.correctKeyBtn.Click += new System.EventHandler(this.correctKeyBtn_Click);
            // 
            // wrongKeyBtn
            // 
            this.wrongKeyBtn.Location = new System.Drawing.Point(140, 364);
            this.wrongKeyBtn.Name = "wrongKeyBtn";
            this.wrongKeyBtn.Size = new System.Drawing.Size(95, 56);
            this.wrongKeyBtn.TabIndex = 9;
            this.wrongKeyBtn.Text = "Wrong Key";
            this.wrongKeyBtn.UseVisualStyleBackColor = true;
            this.wrongKeyBtn.Click += new System.EventHandler(this.wrongKeyBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 475);
            this.Controls.Add(this.wrongKeyBtn);
            this.Controls.Add(this.correctKeyBtn);
            this.Controls.Add(this.decryptFileBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyLbl);
            this.Controls.Add(this.keyTxtBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.FeedbackTxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox FeedbackTxtBox;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox keyTxtBox;
        private System.Windows.Forms.Label keyLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button decryptFileBtn;
        private System.Windows.Forms.Button correctKeyBtn;
        private System.Windows.Forms.Button wrongKeyBtn;
    }
}

