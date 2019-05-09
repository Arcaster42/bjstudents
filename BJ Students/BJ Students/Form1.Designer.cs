namespace BJ_Students
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentList = new System.Windows.Forms.ListBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mainClassLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvlLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.lLbl = new System.Windows.Forms.Label();
            this.fLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.muLbl4 = new System.Windows.Forms.Label();
            this.muLbl3 = new System.Windows.Forms.Label();
            this.muLbl2 = new System.Windows.Forms.Label();
            this.muLbl1 = new System.Windows.Forms.Label();
            this.detailsBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.classesBtn = new System.Windows.Forms.Button();
            this.scheduleBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.studentList);
            this.groupBox1.Controls.Add(this.searchBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Students";
            // 
            // studentList
            // 
            this.studentList.FormattingEnabled = true;
            this.studentList.Location = new System.Drawing.Point(6, 45);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(188, 199);
            this.studentList.TabIndex = 1;
            this.studentList.SelectedIndexChanged += new System.EventHandler(this.studentList_SelectedIndexChanged);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(6, 19);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(188, 20);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mainClassLbl);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lvlLbl);
            this.groupBox2.Controls.Add(this.idLbl);
            this.groupBox2.Controls.Add(this.lLbl);
            this.groupBox2.Controls.Add(this.fLbl);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(219, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(270, 153);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Data";
            // 
            // mainClassLbl
            // 
            this.mainClassLbl.AutoSize = true;
            this.mainClassLbl.Location = new System.Drawing.Point(129, 96);
            this.mainClassLbl.Name = "mainClassLbl";
            this.mainClassLbl.Size = new System.Drawing.Size(0, 13);
            this.mainClassLbl.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Student ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Class";
            // 
            // lvlLbl
            // 
            this.lvlLbl.AutoSize = true;
            this.lvlLbl.Location = new System.Drawing.Point(129, 71);
            this.lvlLbl.Name = "lvlLbl";
            this.lvlLbl.Size = new System.Drawing.Size(0, 13);
            this.lvlLbl.TabIndex = 11;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(129, 121);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(0, 13);
            this.idLbl.TabIndex = 15;
            // 
            // lLbl
            // 
            this.lLbl.AutoSize = true;
            this.lLbl.Location = new System.Drawing.Point(129, 46);
            this.lLbl.Name = "lLbl";
            this.lLbl.Size = new System.Drawing.Size(0, 13);
            this.lLbl.TabIndex = 10;
            // 
            // fLbl
            // 
            this.fLbl.AutoSize = true;
            this.fLbl.Location = new System.Drawing.Point(129, 21);
            this.fLbl.Name = "fLbl";
            this.fLbl.Size = new System.Drawing.Size(0, 13);
            this.fLbl.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "First Name";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(435, 295);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(56, 19);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(435, 276);
            this.loadBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(56, 19);
            this.loadBtn.TabIndex = 4;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(18, 276);
            this.newBtn.Margin = new System.Windows.Forms.Padding(2);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(89, 19);
            this.newBtn.TabIndex = 5;
            this.newBtn.Text = "New Student";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.muLbl4);
            this.groupBox3.Controls.Add(this.muLbl3);
            this.groupBox3.Controls.Add(this.muLbl2);
            this.groupBox3.Controls.Add(this.muLbl1);
            this.groupBox3.Location = new System.Drawing.Point(219, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 100);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Make-Up Classes";
            // 
            // muLbl4
            // 
            this.muLbl4.AutoSize = true;
            this.muLbl4.Location = new System.Drawing.Point(129, 61);
            this.muLbl4.Name = "muLbl4";
            this.muLbl4.Size = new System.Drawing.Size(0, 13);
            this.muLbl4.TabIndex = 3;
            // 
            // muLbl3
            // 
            this.muLbl3.AutoSize = true;
            this.muLbl3.Location = new System.Drawing.Point(129, 30);
            this.muLbl3.Name = "muLbl3";
            this.muLbl3.Size = new System.Drawing.Size(0, 13);
            this.muLbl3.TabIndex = 2;
            // 
            // muLbl2
            // 
            this.muLbl2.AutoSize = true;
            this.muLbl2.Location = new System.Drawing.Point(6, 61);
            this.muLbl2.Name = "muLbl2";
            this.muLbl2.Size = new System.Drawing.Size(0, 13);
            this.muLbl2.TabIndex = 1;
            // 
            // muLbl1
            // 
            this.muLbl1.AutoSize = true;
            this.muLbl1.Location = new System.Drawing.Point(6, 30);
            this.muLbl1.Name = "muLbl1";
            this.muLbl1.Size = new System.Drawing.Size(0, 13);
            this.muLbl1.TabIndex = 0;
            // 
            // detailsBtn
            // 
            this.detailsBtn.Location = new System.Drawing.Point(117, 276);
            this.detailsBtn.Name = "detailsBtn";
            this.detailsBtn.Size = new System.Drawing.Size(89, 19);
            this.detailsBtn.TabIndex = 13;
            this.detailsBtn.Text = "Details";
            this.detailsBtn.UseVisualStyleBackColor = true;
            this.detailsBtn.Click += new System.EventHandler(this.detailsBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(18, 300);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(89, 19);
            this.editBtn.TabIndex = 14;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(18, 325);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(89, 19);
            this.deleteBtn.TabIndex = 16;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // classesBtn
            // 
            this.classesBtn.Location = new System.Drawing.Point(117, 301);
            this.classesBtn.Name = "classesBtn";
            this.classesBtn.Size = new System.Drawing.Size(89, 19);
            this.classesBtn.TabIndex = 17;
            this.classesBtn.Text = "Lessons";
            this.classesBtn.UseVisualStyleBackColor = true;
            this.classesBtn.Click += new System.EventHandler(this.classesBtn_Click);
            // 
            // scheduleBtn
            // 
            this.scheduleBtn.Location = new System.Drawing.Point(117, 326);
            this.scheduleBtn.Name = "scheduleBtn";
            this.scheduleBtn.Size = new System.Drawing.Size(89, 19);
            this.scheduleBtn.TabIndex = 18;
            this.scheduleBtn.Text = "Schedule";
            this.scheduleBtn.UseVisualStyleBackColor = true;
            this.scheduleBtn.Click += new System.EventHandler(this.scheduleBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 369);
            this.Controls.Add(this.scheduleBtn);
            this.Controls.Add(this.classesBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.detailsBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "BJ Students";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchBox;
        public System.Windows.Forms.ListBox studentList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lvlLbl;
        private System.Windows.Forms.Label lLbl;
        private System.Windows.Forms.Label fLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label muLbl2;
        private System.Windows.Forms.Label muLbl1;
        private System.Windows.Forms.Label muLbl4;
        private System.Windows.Forms.Label muLbl3;
        private System.Windows.Forms.Button detailsBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label mainClassLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button classesBtn;
        private System.Windows.Forms.Button scheduleBtn;
    }
}

