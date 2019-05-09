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
    public partial class NewTrial : Form
    {
        BindingList<Student> students = new BindingList<Student>();
        LessonInstance instance = new LessonInstance(-1, null, null, -1, -1, DateTime.Now, null, null, null, null, null, null, null);
        Student selected;

        public NewTrial()
        {
            InitializeComponent();
        }

        public NewTrial(BindingList<Student> allStudents, LessonInstance passed_instance)
        {
            InitializeComponent();
            students = allStudents;
            instance = passed_instance;
            List<Student> displayStudents = new List<Student>();
            displayStudents.AddRange(students);
            displayStudents = displayStudents.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList<Student>();
            studentBox.DataSource = displayStudents;
            studentBox.DisplayMember = "FullName";
            studentBox.ValueMember = "ID";
        }

        private void studentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = (Student)studentBox.SelectedItem;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (studentBox.SelectedIndex != -1)
            {
                instance.Trial.Add(selected);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Select Student");
                return;
            }
        }

        private void NewTrial_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
