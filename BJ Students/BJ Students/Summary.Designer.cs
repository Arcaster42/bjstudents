namespace BJ_Students
{
    partial class Summary
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
            this.summaryBox = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // summaryBox
            // 
            this.summaryBox.Location = new System.Drawing.Point(12, 11);
            this.summaryBox.Multiline = true;
            this.summaryBox.Name = "summaryBox";
            this.summaryBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.summaryBox.Size = new System.Drawing.Size(311, 226);
            this.summaryBox.TabIndex = 0;
            this.summaryBox.TextChanged += new System.EventHandler(this.summaryBox_TextChanged);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(248, 244);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 21);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(12, 243);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(75, 21);
            this.printBtn.TabIndex = 2;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 277);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.summaryBox);
            this.Name = "Summary";
            this.Text = "Summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox summaryBox;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button printBtn;
    }
}