namespace BJ_Students
{
    partial class CreateStudent
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
            this.createBtn = new System.Windows.Forms.Button();
            this.firstBox = new System.Windows.Forms.TextBox();
            this.lastBox = new System.Windows.Forms.TextBox();
            this.levelBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.classBox = new System.Windows.Forms.ComboBox();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listeningBox = new System.Windows.Forms.TextBox();
            this.writingBox = new System.Windows.Forms.TextBox();
            this.readingBox = new System.Windows.Forms.TextBox();
            this.speakingBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(12, 304);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 0;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // firstBox
            // 
            this.firstBox.Location = new System.Drawing.Point(104, 19);
            this.firstBox.Name = "firstBox";
            this.firstBox.Size = new System.Drawing.Size(122, 20);
            this.firstBox.TabIndex = 1;
            this.firstBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lastBox
            // 
            this.lastBox.Location = new System.Drawing.Point(104, 45);
            this.lastBox.Name = "lastBox";
            this.lastBox.Size = new System.Drawing.Size(122, 20);
            this.lastBox.TabIndex = 2;
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
            this.levelBox.Location = new System.Drawing.Point(104, 71);
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(61, 21);
            this.levelBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.classBox);
            this.groupBox1.Controls.Add(this.notesBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.listeningBox);
            this.groupBox1.Controls.Add(this.writingBox);
            this.groupBox1.Controls.Add(this.readingBox);
            this.groupBox1.Controls.Add(this.speakingBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.firstBox);
            this.groupBox1.Controls.Add(this.levelBox);
            this.groupBox1.Controls.Add(this.lastBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 151);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Class";
            // 
            // classBox
            // 
            this.classBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classBox.FormattingEnabled = true;
            this.classBox.Items.AddRange(new object[] {
            "Mon AD1 1:30 (N)",
            "Mon B2 2:40 (T)",
            "Mon IM2 7:30 (T)",
            "Tue B0 1:00 (T)",
            "Tue IM1 1:00 (N)",
            "Tue B2 2:35 (T)",
            "Tue IM1 7:50 (T)",
            "Wed IM1 12:30 (N)",
            "Wed AD1 7:00 (N)",
            "Wed IM1 7:40 (T)",
            "Thu IM1 1:00 (N)",
            "Thu IM2 2:10 (N)",
            "Thu B1 2:30 (T)",
            "Thu B2 7:40 (T)",
            "Fri AD1 1:00 (N)",
            "Fri B0 6:40 (T)",
            "Fri IM1 7:50 (T)"});
            this.classBox.Location = new System.Drawing.Point(104, 98);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(122, 21);
            this.classBox.TabIndex = 4;
            // 
            // notesBox
            // 
            this.notesBox.Location = new System.Drawing.Point(444, 38);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(140, 95);
            this.notesBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(495, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Notes";
            // 
            // listeningBox
            // 
            this.listeningBox.Location = new System.Drawing.Point(398, 38);
            this.listeningBox.Name = "listeningBox";
            this.listeningBox.Size = new System.Drawing.Size(30, 20);
            this.listeningBox.TabIndex = 14;
            // 
            // writingBox
            // 
            this.writingBox.Location = new System.Drawing.Point(348, 38);
            this.writingBox.Name = "writingBox";
            this.writingBox.Size = new System.Drawing.Size(30, 20);
            this.writingBox.TabIndex = 13;
            // 
            // readingBox
            // 
            this.readingBox.Location = new System.Drawing.Point(298, 38);
            this.readingBox.Name = "readingBox";
            this.readingBox.Size = new System.Drawing.Size(30, 20);
            this.readingBox.TabIndex = 12;
            // 
            // speakingBox
            // 
            this.speakingBox.Location = new System.Drawing.Point(245, 38);
            this.speakingBox.Name = "speakingBox";
            this.speakingBox.Size = new System.Drawing.Size(30, 20);
            this.speakingBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Writing";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Reading";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Listening";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Speaking";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox17);
            this.groupBox2.Controls.Add(this.checkBox16);
            this.groupBox2.Controls.Add(this.checkBox15);
            this.groupBox2.Controls.Add(this.checkBox14);
            this.groupBox2.Controls.Add(this.checkBox13);
            this.groupBox2.Controls.Add(this.checkBox12);
            this.groupBox2.Controls.Add(this.checkBox11);
            this.groupBox2.Controls.Add(this.checkBox10);
            this.groupBox2.Controls.Add(this.checkBox9);
            this.groupBox2.Controls.Add(this.checkBox8);
            this.groupBox2.Controls.Add(this.checkBox7);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 118);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valid Classes";
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(480, 19);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(102, 17);
            this.checkBox17.TabIndex = 15;
            this.checkBox17.Text = "Fri AD1 1:00 (N)";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(362, 42);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(107, 17);
            this.checkBox16.TabIndex = 14;
            this.checkBox16.Text = "Thu IM2 2:10 (N)";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(362, 19);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(107, 17);
            this.checkBox15.TabIndex = 13;
            this.checkBox15.Text = "Thu IM1 1:00 (N)";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(239, 42);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(114, 17);
            this.checkBox14.TabIndex = 12;
            this.checkBox14.Text = "Wed AD1 7:00 (N)";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(239, 19);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(117, 17);
            this.checkBox13.TabIndex = 11;
            this.checkBox13.Text = "Wed IM1 12:30 (N)";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(126, 42);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(107, 17);
            this.checkBox12.TabIndex = 10;
            this.checkBox12.Text = "Tue IM1 1:00 (N)";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(9, 19);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(112, 17);
            this.checkBox11.TabIndex = 9;
            this.checkBox11.Text = "Mon AD1 1:30 (N)";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(480, 65);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(98, 17);
            this.checkBox10.TabIndex = 8;
            this.checkBox10.Text = "Fri IM1 7:50 (T)";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(480, 42);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(93, 17);
            this.checkBox9.TabIndex = 6;
            this.checkBox9.Text = "Fri B0 6:40 (T)";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(362, 88);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(101, 17);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "Thu B2 7:40 (T)";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(362, 65);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(101, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Thu B1 2:30 (T)";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(239, 65);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(110, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Wed IM1 7:40 (T)";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(126, 88);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(106, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Tue IM1 7:50 (T)";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(126, 65);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(101, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Tue B2 2:35 (T)";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(126, 19);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(101, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Tue B0 1:00 (T)";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 65);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(108, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Mon IM2 7:30 (T)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(103, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Mon B2 2:40 (T)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(527, 304);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // CreateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 339);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.createBtn);
            this.Name = "CreateStudent";
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.CreateStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox firstBox;
        private System.Windows.Forms.TextBox lastBox;
        private System.Windows.Forms.ComboBox levelBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox listeningBox;
        private System.Windows.Forms.TextBox writingBox;
        private System.Windows.Forms.TextBox readingBox;
        private System.Windows.Forms.TextBox speakingBox;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox classBox;
    }
}