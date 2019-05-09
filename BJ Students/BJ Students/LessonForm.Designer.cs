namespace BJ_Students
{
    partial class LessonForm
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
            this.lessonBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.membersBox = new System.Windows.Forms.ListBox();
            this.newBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.memberBtn = new System.Windows.Forms.Button();
            this.deleteMBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvlLbl = new System.Windows.Forms.Label();
            this.teacherLbl = new System.Windows.Forms.Label();
            this.roomLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lessonBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lessons";
            // 
            // lessonBox
            // 
            this.lessonBox.FormattingEnabled = true;
            this.lessonBox.Location = new System.Drawing.Point(6, 20);
            this.lessonBox.Name = "lessonBox";
            this.lessonBox.Size = new System.Drawing.Size(154, 394);
            this.lessonBox.TabIndex = 0;
            this.lessonBox.SelectedIndexChanged += new System.EventHandler(this.lessonBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.timeLbl);
            this.groupBox2.Controls.Add(this.roomLbl);
            this.groupBox2.Controls.Add(this.teacherLbl);
            this.groupBox2.Controls.Add(this.lvlLbl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(184, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.membersBox);
            this.groupBox3.Location = new System.Drawing.Point(184, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 173);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Members";
            // 
            // membersBox
            // 
            this.membersBox.FormattingEnabled = true;
            this.membersBox.Location = new System.Drawing.Point(6, 20);
            this.membersBox.Name = "membersBox";
            this.membersBox.Size = new System.Drawing.Size(188, 134);
            this.membersBox.TabIndex = 0;
            this.membersBox.SelectedIndexChanged += new System.EventHandler(this.membersBox_SelectedIndexChanged);
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(184, 367);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(90, 23);
            this.newBtn.TabIndex = 3;
            this.newBtn.Text = "New Lesson";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(184, 397);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(90, 23);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "Edit Lesson";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(184, 426);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(90, 23);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete Lesson";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // memberBtn
            // 
            this.memberBtn.Location = new System.Drawing.Point(294, 367);
            this.memberBtn.Name = "memberBtn";
            this.memberBtn.Size = new System.Drawing.Size(90, 23);
            this.memberBtn.TabIndex = 6;
            this.memberBtn.Text = "New Member";
            this.memberBtn.UseVisualStyleBackColor = true;
            this.memberBtn.Click += new System.EventHandler(this.memberBtn_Click);
            // 
            // deleteMBtn
            // 
            this.deleteMBtn.Location = new System.Drawing.Point(294, 397);
            this.deleteMBtn.Name = "deleteMBtn";
            this.deleteMBtn.Size = new System.Drawing.Size(90, 23);
            this.deleteMBtn.TabIndex = 7;
            this.deleteMBtn.Text = "Delete Member";
            this.deleteMBtn.UseVisualStyleBackColor = true;
            this.deleteMBtn.Click += new System.EventHandler(this.deleteMBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Teacher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Room";
            // 
            // lvlLbl
            // 
            this.lvlLbl.AutoSize = true;
            this.lvlLbl.Location = new System.Drawing.Point(107, 32);
            this.lvlLbl.Name = "lvlLbl";
            this.lvlLbl.Size = new System.Drawing.Size(31, 13);
            this.lvlLbl.TabIndex = 12;
            this.lvlLbl.Text = "lvlLbl";
            // 
            // teacherLbl
            // 
            this.teacherLbl.AutoSize = true;
            this.teacherLbl.Location = new System.Drawing.Point(107, 80);
            this.teacherLbl.Name = "teacherLbl";
            this.teacherLbl.Size = new System.Drawing.Size(57, 13);
            this.teacherLbl.TabIndex = 13;
            this.teacherLbl.Text = "teacherLbl";
            // 
            // roomLbl
            // 
            this.roomLbl.AutoSize = true;
            this.roomLbl.Location = new System.Drawing.Point(107, 104);
            this.roomLbl.Name = "roomLbl";
            this.roomLbl.Size = new System.Drawing.Size(44, 13);
            this.roomLbl.TabIndex = 14;
            this.roomLbl.Text = "roomLbl";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(107, 56);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(40, 13);
            this.timeLbl.TabIndex = 15;
            this.timeLbl.Text = "timeLbl";
            // 
            // LessonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 455);
            this.Controls.Add(this.deleteMBtn);
            this.Controls.Add(this.memberBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LessonForm";
            this.Text = "Lessons";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LessonForm_FormClosing);
            this.Load += new System.EventHandler(this.LessonForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ListBox lessonBox;
        private System.Windows.Forms.ListBox membersBox;
        private System.Windows.Forms.Button memberBtn;
        private System.Windows.Forms.Button deleteMBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label roomLbl;
        private System.Windows.Forms.Label teacherLbl;
        private System.Windows.Forms.Label lvlLbl;
        private System.Windows.Forms.Label timeLbl;
    }
}