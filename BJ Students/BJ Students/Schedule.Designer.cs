namespace BJ_Students
{
    partial class Schedule
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scheduleCal = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lessonBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trialBox = new System.Windows.Forms.ListBox();
            this.trialBtn = new System.Windows.Forms.Button();
            this.summaryBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.makeupBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.attendBtn = new System.Windows.Forms.Button();
            this.makeupBtn = new System.Windows.Forms.Button();
            this.absentBtn = new System.Windows.Forms.Button();
            this.absentBox = new System.Windows.Forms.ListBox();
            this.attendBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scheduleCal);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calendar";
            // 
            // scheduleCal
            // 
            this.scheduleCal.Location = new System.Drawing.Point(6, 23);
            this.scheduleCal.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.scheduleCal.MaxSelectionCount = 1;
            this.scheduleCal.Name = "scheduleCal";
            this.scheduleCal.TabIndex = 0;
            this.scheduleCal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.scheduleCal_DateChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lessonBox);
            this.groupBox2.Location = new System.Drawing.Point(260, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 188);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lessons";
            // 
            // lessonBox
            // 
            this.lessonBox.FormattingEnabled = true;
            this.lessonBox.ItemHeight = 12;
            this.lessonBox.Location = new System.Drawing.Point(6, 23);
            this.lessonBox.Name = "lessonBox";
            this.lessonBox.Size = new System.Drawing.Size(143, 148);
            this.lessonBox.TabIndex = 0;
            this.lessonBox.SelectedIndexChanged += new System.EventHandler(this.lessonBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.trialBox);
            this.groupBox3.Controls.Add(this.trialBtn);
            this.groupBox3.Controls.Add(this.summaryBtn);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.makeupBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.attendBtn);
            this.groupBox3.Controls.Add(this.makeupBtn);
            this.groupBox3.Controls.Add(this.absentBtn);
            this.groupBox3.Controls.Add(this.absentBox);
            this.groupBox3.Controls.Add(this.attendBox);
            this.groupBox3.Location = new System.Drawing.Point(511, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(622, 188);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Students";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "Trial";
            // 
            // trialBox
            // 
            this.trialBox.FormattingEnabled = true;
            this.trialBox.ItemHeight = 12;
            this.trialBox.Location = new System.Drawing.Point(378, 35);
            this.trialBox.Name = "trialBox";
            this.trialBox.Size = new System.Drawing.Size(118, 136);
            this.trialBox.TabIndex = 11;
            this.trialBox.SelectedIndexChanged += new System.EventHandler(this.trialBox_SelectedIndexChanged_1);
            // 
            // trialBtn
            // 
            this.trialBtn.Location = new System.Drawing.Point(529, 115);
            this.trialBtn.Name = "trialBtn";
            this.trialBtn.Size = new System.Drawing.Size(75, 21);
            this.trialBtn.TabIndex = 10;
            this.trialBtn.Text = "Trial";
            this.trialBtn.UseVisualStyleBackColor = true;
            this.trialBtn.Click += new System.EventHandler(this.trialBtn_Click);
            // 
            // summaryBtn
            // 
            this.summaryBtn.Location = new System.Drawing.Point(529, 142);
            this.summaryBtn.Name = "summaryBtn";
            this.summaryBtn.Size = new System.Drawing.Size(75, 21);
            this.summaryBtn.TabIndex = 9;
            this.summaryBtn.Text = "Summary";
            this.summaryBtn.UseVisualStyleBackColor = true;
            this.summaryBtn.Click += new System.EventHandler(this.summaryBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Make-Up";
            // 
            // makeupBox
            // 
            this.makeupBox.FormattingEnabled = true;
            this.makeupBox.ItemHeight = 12;
            this.makeupBox.Location = new System.Drawing.Point(254, 35);
            this.makeupBox.Name = "makeupBox";
            this.makeupBox.Size = new System.Drawing.Size(118, 136);
            this.makeupBox.TabIndex = 7;
            this.makeupBox.SelectedIndexChanged += new System.EventHandler(this.makeupBox_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Absent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Attending";
            // 
            // attendBtn
            // 
            this.attendBtn.Location = new System.Drawing.Point(529, 62);
            this.attendBtn.Name = "attendBtn";
            this.attendBtn.Size = new System.Drawing.Size(75, 21);
            this.attendBtn.TabIndex = 4;
            this.attendBtn.Text = "Attending";
            this.attendBtn.UseVisualStyleBackColor = true;
            this.attendBtn.Click += new System.EventHandler(this.attendBtn_Click);
            // 
            // makeupBtn
            // 
            this.makeupBtn.Location = new System.Drawing.Point(529, 89);
            this.makeupBtn.Name = "makeupBtn";
            this.makeupBtn.Size = new System.Drawing.Size(75, 21);
            this.makeupBtn.TabIndex = 3;
            this.makeupBtn.Text = "Make-Up";
            this.makeupBtn.UseVisualStyleBackColor = true;
            this.makeupBtn.Click += new System.EventHandler(this.makeupBtn_Click);
            // 
            // absentBtn
            // 
            this.absentBtn.Location = new System.Drawing.Point(529, 35);
            this.absentBtn.Name = "absentBtn";
            this.absentBtn.Size = new System.Drawing.Size(75, 21);
            this.absentBtn.TabIndex = 2;
            this.absentBtn.Text = "Absent";
            this.absentBtn.UseVisualStyleBackColor = true;
            this.absentBtn.Click += new System.EventHandler(this.absentBtn_Click);
            // 
            // absentBox
            // 
            this.absentBox.FormattingEnabled = true;
            this.absentBox.ItemHeight = 12;
            this.absentBox.Location = new System.Drawing.Point(130, 35);
            this.absentBox.Name = "absentBox";
            this.absentBox.Size = new System.Drawing.Size(118, 136);
            this.absentBox.TabIndex = 1;
            this.absentBox.SelectedIndexChanged += new System.EventHandler(this.absentBox_SelectedIndexChanged);
            // 
            // attendBox
            // 
            this.attendBox.FormattingEnabled = true;
            this.attendBox.ItemHeight = 12;
            this.attendBox.Location = new System.Drawing.Point(6, 35);
            this.attendBox.Name = "attendBox";
            this.attendBox.Size = new System.Drawing.Size(118, 136);
            this.attendBox.TabIndex = 0;
            this.attendBox.SelectedIndexChanged += new System.EventHandler(this.attendBox_SelectedIndexChanged);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 220);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Schedule_FormClosing);
            this.Load += new System.EventHandler(this.Schedule_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar scheduleCal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lessonBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox absentBox;
        private System.Windows.Forms.ListBox attendBox;
        private System.Windows.Forms.Button absentBtn;
        private System.Windows.Forms.Button makeupBtn;
        private System.Windows.Forms.Button attendBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox makeupBox;
        private System.Windows.Forms.Button summaryBtn;
        private System.Windows.Forms.Button trialBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox trialBox;
    }
}