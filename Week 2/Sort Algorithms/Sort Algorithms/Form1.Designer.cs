namespace Sort_Algorithms
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bubbleBtn = new System.Windows.Forms.RadioButton();
            this.selectionBtn = new System.Windows.Forms.RadioButton();
            this.insertionBtn = new System.Windows.Forms.RadioButton();
            this.mergeBtn = new System.Windows.Forms.RadioButton();
            this.sortBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(276, 388);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mergeBtn);
            this.groupBox1.Controls.Add(this.insertionBtn);
            this.groupBox1.Controls.Add(this.selectionBtn);
            this.groupBox1.Controls.Add(this.bubbleBtn);
            this.groupBox1.Location = new System.Drawing.Point(307, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort Type";
            // 
            // bubbleBtn
            // 
            this.bubbleBtn.AutoSize = true;
            this.bubbleBtn.Location = new System.Drawing.Point(7, 31);
            this.bubbleBtn.Name = "bubbleBtn";
            this.bubbleBtn.Size = new System.Drawing.Size(103, 21);
            this.bubbleBtn.TabIndex = 0;
            this.bubbleBtn.TabStop = true;
            this.bubbleBtn.Text = "Bubble Sort";
            this.bubbleBtn.UseVisualStyleBackColor = true;
            // 
            // selectionBtn
            // 
            this.selectionBtn.AutoSize = true;
            this.selectionBtn.Location = new System.Drawing.Point(7, 58);
            this.selectionBtn.Name = "selectionBtn";
            this.selectionBtn.Size = new System.Drawing.Size(117, 21);
            this.selectionBtn.TabIndex = 1;
            this.selectionBtn.TabStop = true;
            this.selectionBtn.Text = "Selection Sort";
            this.selectionBtn.UseVisualStyleBackColor = true;
            // 
            // insertionBtn
            // 
            this.insertionBtn.AutoSize = true;
            this.insertionBtn.Location = new System.Drawing.Point(7, 85);
            this.insertionBtn.Name = "insertionBtn";
            this.insertionBtn.Size = new System.Drawing.Size(113, 21);
            this.insertionBtn.TabIndex = 2;
            this.insertionBtn.TabStop = true;
            this.insertionBtn.Text = "Insertion Sort";
            this.insertionBtn.UseVisualStyleBackColor = true;
            // 
            // mergeBtn
            // 
            this.mergeBtn.AutoSize = true;
            this.mergeBtn.Location = new System.Drawing.Point(6, 112);
            this.mergeBtn.Name = "mergeBtn";
            this.mergeBtn.Size = new System.Drawing.Size(99, 21);
            this.mergeBtn.TabIndex = 3;
            this.mergeBtn.TabStop = true;
            this.mergeBtn.Text = "Merge Sort";
            this.mergeBtn.UseVisualStyleBackColor = true;
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(307, 338);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(184, 49);
            this.sortBtn.TabIndex = 2;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(307, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter how many Numbers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "to Sort";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 408);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton mergeBtn;
        private System.Windows.Forms.RadioButton insertionBtn;
        private System.Windows.Forms.RadioButton selectionBtn;
        private System.Windows.Forms.RadioButton bubbleBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

