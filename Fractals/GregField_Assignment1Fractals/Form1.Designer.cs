namespace GregField_Assignment1Fractals
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
            this.label1 = new System.Windows.Forms.Label();
            this.depthTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.triangleBtn = new System.Windows.Forms.Button();
            this.snowflakeBtn = new System.Windows.Forms.Button();
            this.treeBtn = new System.Windows.Forms.Button();
            this.squaresBtn = new System.Windows.Forms.Button();
            this.dragonBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fractal Depth:";
            // 
            // depthTxtBox
            // 
            this.depthTxtBox.Location = new System.Drawing.Point(117, 24);
            this.depthTxtBox.Name = "depthTxtBox";
            this.depthTxtBox.Size = new System.Drawing.Size(100, 22);
            this.depthTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fractal Pattern:";
            // 
            // triangleBtn
            // 
            this.triangleBtn.Location = new System.Drawing.Point(16, 133);
            this.triangleBtn.Name = "triangleBtn";
            this.triangleBtn.Size = new System.Drawing.Size(109, 53);
            this.triangleBtn.TabIndex = 3;
            this.triangleBtn.Text = "Sierpinski\'s Triangle";
            this.triangleBtn.UseVisualStyleBackColor = true;
            this.triangleBtn.Click += new System.EventHandler(this.triangleBtn_Click);
            // 
            // snowflakeBtn
            // 
            this.snowflakeBtn.Location = new System.Drawing.Point(15, 192);
            this.snowflakeBtn.Name = "snowflakeBtn";
            this.snowflakeBtn.Size = new System.Drawing.Size(109, 53);
            this.snowflakeBtn.TabIndex = 4;
            this.snowflakeBtn.Text = "Koch\'s Snowflake";
            this.snowflakeBtn.UseVisualStyleBackColor = true;
            this.snowflakeBtn.Click += new System.EventHandler(this.snowflakeBtn_Click);
            // 
            // treeBtn
            // 
            this.treeBtn.Location = new System.Drawing.Point(16, 251);
            this.treeBtn.Name = "treeBtn";
            this.treeBtn.Size = new System.Drawing.Size(109, 53);
            this.treeBtn.TabIndex = 5;
            this.treeBtn.Text = "Tree";
            this.treeBtn.UseVisualStyleBackColor = true;
            this.treeBtn.Click += new System.EventHandler(this.treeBtn_Click);
            // 
            // squaresBtn
            // 
            this.squaresBtn.Location = new System.Drawing.Point(16, 310);
            this.squaresBtn.Name = "squaresBtn";
            this.squaresBtn.Size = new System.Drawing.Size(109, 53);
            this.squaresBtn.TabIndex = 6;
            this.squaresBtn.Text = "Squares";
            this.squaresBtn.UseVisualStyleBackColor = true;
            this.squaresBtn.Click += new System.EventHandler(this.squaresBtn_Click);
            // 
            // dragonBtn
            // 
            this.dragonBtn.Location = new System.Drawing.Point(16, 369);
            this.dragonBtn.Name = "dragonBtn";
            this.dragonBtn.Size = new System.Drawing.Size(109, 53);
            this.dragonBtn.TabIndex = 7;
            this.dragonBtn.Text = "Dragon Curve";
            this.dragonBtn.UseVisualStyleBackColor = true;
            this.dragonBtn.Click += new System.EventHandler(this.dragonBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 676);
            this.Controls.Add(this.dragonBtn);
            this.Controls.Add(this.squaresBtn);
            this.Controls.Add(this.treeBtn);
            this.Controls.Add(this.snowflakeBtn);
            this.Controls.Add(this.triangleBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.depthTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fractals";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox depthTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button triangleBtn;
        private System.Windows.Forms.Button snowflakeBtn;
        private System.Windows.Forms.Button treeBtn;
        private System.Windows.Forms.Button squaresBtn;
        private System.Windows.Forms.Button dragonBtn;
    }
}

