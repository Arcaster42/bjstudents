using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJ_Students
{
    public partial class NewMember : Form
    {
        public Student selection;
        public Lesson lesson;

        public NewMember(BindingList<Student> students, Lesson lesson_passed)
        {
            InitializeComponent();
            List<Student> displayStudents = new List<Student>();
            displayStudents.AddRange(students);
            displayStudents = displayStudents.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList<Student>();
            studentBox.DataSource = displayStudents;
            studentBox.DisplayMember = "FullName";
            studentBox.ValueMember = "ID";
            lesson = lesson_passed;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (studentBox.SelectedIndex != -1)
            {
                selection = (Student)studentBox.SelectedItem;
                lesson.Members.Add(selection);
            }
            this.Close();
        }

        private void NewMember_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private Lesson NewMember_FormClosing(object sender, EventArgs e)
        {
            return lesson;
        }

        private void studentBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
