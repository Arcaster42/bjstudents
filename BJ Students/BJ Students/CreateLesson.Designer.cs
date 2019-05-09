namespace BJ_Students
{
    partial class CreateLesson
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
            this.levelBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.roomBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teacherBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minuteBox = new System.Windows.Forms.ComboBox();
            this.hourBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dayBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.levelBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.roomBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.teacherBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.minuteBox);
            this.groupBox1.Controls.Add(this.hourBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dayBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lesson Details";
            // 
            // levelBox
            // 
            this.levelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelBox.FormattingEnabled = true;
            this.levelBox.Items.AddRange(new object[] {
            "B0",
            "B1",
            "B2",
            "IM1",
            "IM2",
            "AD1",
            "AD2"});
            this.levelBox.Location = new System.Drawing.Point(74, 51);
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(55, 20);
            this.levelBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Level";
            // 
            // roomBox
            // 
            this.roomBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomBox.FormattingEnabled = true;
            this.roomBox.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Orange",
            "Blue"});
            this.roomBox.Location = new System.Drawing.Point(74, 126);
            this.roomBox.Name = "roomBox";
            this.roomBox.Size = new System.Drawing.Size(121, 20);
            this.roomBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Room";
            // 
            // teacherBox
            // 
            this.teacherBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherBox.FormattingEnabled = true;
            this.teacherBox.Items.AddRange(new object[] {
            "Terry",
            "Nathan",
            "Samantha",
            "Leigh"});
            this.teacherBox.Location = new System.Drawing.Point(74, 101);
            this.teacherBox.Name = "teacherBox";
            this.teacherBox.Size = new System.Drawing.Size(121, 20);
            this.teacherBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Teacher";
            // 
            // minuteBox
            // 
            this.minuteBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minuteBox.FormattingEnabled = true;
            this.minuteBox.Items.AddRange(new object[] {
            "00",
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.minuteBox.Location = new System.Drawing.Point(140, 76);
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.Size = new System.Drawing.Size(55, 20);
            this.minuteBox.TabIndex = 4;
            // 
            // hourBox
            // 
            this.hourBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hourBox.FormattingEnabled = true;
            this.hourBox.Items.AddRange(new object[] {
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.hourBox.Location = new System.Drawing.Point(74, 76);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(55, 20);
            this.hourBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time";
            // 
            // dayBox
            // 
            this.dayBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayBox.FormattingEnabled = true;
            this.dayBox.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.dayBox.Location = new System.Drawing.Point(74, 26);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(121, 20);
            this.dayBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Day";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(12, 186);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 21);
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click_1);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(138, 186);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 21);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // CreateLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 214);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateLesson";
            this.Text = "Create Lesson";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateLesson_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox minuteBox;
        private System.Windows.Forms.ComboBox hourBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dayBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox teacherBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox roomBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox levelBox;
        private System.Windows.Forms.Label label5;
    }
}