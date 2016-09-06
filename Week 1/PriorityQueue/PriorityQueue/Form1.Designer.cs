namespace PriorityQueue
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.highPriBtn = new System.Windows.Forms.Button();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(296, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(299, 420);
            this.listBox1.TabIndex = 0;
            // 
            // highPriBtn
            // 
            this.highPriBtn.Location = new System.Drawing.Point(59, 33);
            this.highPriBtn.Name = "highPriBtn";
            this.highPriBtn.Size = new System.Drawing.Size(152, 77);
            this.highPriBtn.TabIndex = 1;
            this.highPriBtn.Text = "Get Highest Priority Patinet";
            this.highPriBtn.UseVisualStyleBackColor = true;
            this.highPriBtn.Click += new System.EventHandler(this.highPriBtn_Click);
            // 
            // showAllBtn
            // 
            this.showAllBtn.Location = new System.Drawing.Point(59, 168);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(152, 77);
            this.showAllBtn.TabIndex = 2;
            this.showAllBtn.Text = "Show All Patinets";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 476);
            this.Controls.Add(this.showAllBtn);
            this.Controls.Add(this.highPriBtn);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button highPriBtn;
        private System.Windows.Forms.Button showAllBtn;
    }
}

