namespace BJ_Students
{
    partial class NewMakeup
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
            this.studentBox = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentBox
            // 
            this.studentBox.FormattingEnabled = true;
            this.studentBox.ItemHeight = 12;
            this.studentBox.Location = new System.Drawing.Point(12, 12);
            this.studentBox.Name = "studentBox";
            this.studentBox.Size = new System.Drawing.Size(190, 124);
            this.studentBox.TabIndex = 1;
            this.studentBox.SelectedIndexChanged += new System.EventHandler(this.studentBox_SelectedIndexChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(69, 148);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 21);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add Student";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // NewMakeup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 181);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.studentBox);
            this.Name = "NewMakeup";
            this.Text = "Make-Up";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox studentBox;
        private System.Windows.Forms.Button addBtn;
    }
}