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
    public partial class CreateStudent : Form
    {
        BindingList<Student> forCreation;
        bool edit_bool;
        public List<string> makeup = new List<string>();
        public Student edit_selection;

        public CreateStudent(BindingList<Student> students, bool edit)
        {
            InitializeComponent();
            forCreation = students;
            edit_bool = edit;
        }

        //this function catches edits as it takes 3 arguments
        //there are probably some inefficiencies here to correct
        public CreateStudent(BindingList<Student> students, bool edit, Student selected)
        {
            InitializeComponent();
            forCreation = students;
            edit_bool = edit;
            edit_selection = selected;
            UpdateEditUI(selected);
        }

        private void CreateStudent_Load(object sender, EventArgs e)
        {

        }

        //repopulate the boxes when editing so user doesn't have to rewrite everything
        public void UpdateEditUI(Student selected)
        {
            if (selected == null)
                return;
            firstBox.Text = selected.FirstName;
            lastBox.Text = selected.LastName;
            //levelBox.Text = GetLevelString(selected.EnLvl);
            levelBox.Text = LISC.GetLevelString(selected.EnLvl);
            classBox.Text = selected.MainClass;
            writingBox.Text = selected.Write.ToString();
            readingBox.Text = selected.Read.ToString();
            listeningBox.Text = selected.Listen.ToString();
            speakingBox.Text = selected.Speak.ToString();
            notesBox.Text = selected.Note;
            for (int i = 0; i < selected.Makeup.Count; i++)
            {
                if (selected.Makeup[i] != null)
                    UpdateEditUIMakeup(selected.Makeup[i]);
            }
            createBtn.Text = "Save";
        }

        //recheck any classes that are already assigned to the object when editing
        //explore the uses of |= operators for simple if-then statements
        public void UpdateEditUIMakeup(string makeupname)
        {
            checkBox1.Checked |= makeupname == "Mon B2 2:40 (T)";
            checkBox2.Checked |= makeupname == "Mon IM2 7:30 (T)";
            checkBox3.Checked |= makeupname == "Tue B0 1:00 (T)";
            if (makeupname == "Tue B2 2:35 (T)")
                checkBox4.Checked = true;
            if (makeupname == "Tue IM1 7:50 (T)")
                checkBox5.Checked = true;
            if (makeupname == "Wed IM1 7:40 (T)")
                checkBox6.Checked = true;
            if (makeupname == "Thu B1 2:30 (T)")
                checkBox7.Checked = true;
            if (makeupname == "Thu B2 7:40 (T)")
                checkBox8.Checked = true;
            if (makeupname == "Fri B0 6:40 (T)")
                checkBox9.Checked = true;
            if (makeupname == "Fri IM2 7:50 (T)")
                checkBox10.Checked = true;
        }
        

        private BindingList<Student> CreateStudent_FormClosing(object sender, EventArgs e)
        {
            return forCreation;
        }

        //This function adds the students into the list which is passed back and reassigned to the list in the main form
        //It also accounts for edits and rewrites entries
        public void AddStudent(int id, string fName, string lName, int enLvl, string mainClass, int speak, int listen, int read, int write, string note)
        {
            //List<string> makeup = new List<string>();
            //SetMakeup(makeup);
            if (edit_bool == false)
            {
                Student student = new Student(id, fName, lName, enLvl, mainClass, makeup, speak, listen, read, write, note);
                forCreation.Add(student);
            }
            if (edit_bool == true)
            {
                foreach (Student s in forCreation)
                {
                    if (s.ID == edit_selection.ID)
                    {
                        s.FirstName = fName;
                        s.LastName = lName;
                        s.EnLvl = enLvl;
                        s.MainClass = mainClass;
                        s.Makeup = makeup;
                        s.Speak = speak;
                        s.Listen = listen;
                        s.Read = read;
                        s.Write = write;
                        s.Note = note;
                    }
                }
            }
        }

        //TO DO: clean up this code formatting
        public void SetMakeup(List<string> makeup)
        {
            if (checkBox1.Checked == true)
            {
                makeup.Add("Mon B2 2:40 (T)");
            }
            if (checkBox2.Checked)
            {
                makeup.Add("Mon IM2 7:30 (T)");
            }
            if (checkBox3.Checked)
            {
                makeup.Add("Tue B0 1:00 (T)");
            }
            if (checkBox4.Checked)
            {
                makeup.Add("Tue B2 2:35 (T)");
            }
            if (checkBox5.Checked)
            {
                makeup.Add("Tue IM1 7:50 (T)");
            }
            if (checkBox6.Checked)
            {
                makeup.Add("Wed IM1 7:40 (T)");
            }
            if (checkBox7.Checked)
            {
                makeup.Add("Thu B1 2:30 (T)");
            }
            if (checkBox8.Checked)
            {
                makeup.Add("Thu B2 7:40 (T)");
            }
            if (checkBox9.Checked)
            {
                makeup.Add("Fri B0 6:40 (T)");
            }
            if (checkBox10.Checked)
            {
                makeup.Add("Fri IM2 7:50 (T)");
            }
            if (checkBox11.Checked)
                makeup.Add("Mon AD1 1:30 (N)");
            if (checkBox12.Checked)
                makeup.Add("Tue IM1 1:00 (N)");
            if (checkBox13.Checked)
                makeup.Add("Wed IM1 12:30 (N)");
            if (checkBox14.Checked)
                makeup.Add("Wed AD1 7:00 (N)");
            if (checkBox15.Checked)
                makeup.Add("Thu IM1 1:00 (N)");
            if (checkBox16.Checked)
                makeup.Add("Thu IM2 2:10 (N)");
            if (checkBox17.Checked)
                makeup.Add("Fri AD1 1:00 (N)");
        }

        //this function triggers the creation process ending with AddStudent
        //we catch bad inputs here including empty strings
        //getting the ID of the last index and adding 1 eliminated ID duplicates
        private void createBtn_Click(object sender, EventArgs e)
        {
            //int lvl = GetEngLevel(levelBox.Text);
            int lvl = LISC.GetEngLevel(levelBox.Text);
            int last = forCreation.Count - 1;
            int id = 0;
            if (last != -1)
                id = forCreation[last].ID + 1;
            if (string.IsNullOrWhiteSpace(firstBox.Text))
            {
                MessageBox.Show("Enter First Name");
                return;
            }
            if (string.IsNullOrWhiteSpace(lastBox.Text))
            {
                MessageBox.Show("Enter Last Name");
                return;
            }
            if (string.IsNullOrEmpty(levelBox.Text))
            {
                MessageBox.Show("Select Level");
                return;
            }
            if (string.IsNullOrEmpty(classBox.Text))
            {
                MessageBox.Show("Select Class");
                return;
            }

            //Makeups are set here and we check for more than 4 selections
            //TRY catches any bad inputs where strings must be converted to integers
            try
            {
                makeup.Clear();
                SetMakeup(makeup);
                if (makeup.Count > 4)
                {
                    MessageBox.Show("Only 4 Classes Allowed");
                    return;
                }
                AddStudent(id, firstBox.Text, lastBox.Text, lvl, classBox.Text, System.Convert.ToInt32(speakingBox.Text), 
                    System.Convert.ToInt32(listeningBox.Text), System.Convert.ToInt32(readingBox.Text), 
                    System.Convert.ToInt32(writingBox.Text), notesBox.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Score Input");
                return;
            }
            firstBox.Clear();
            lastBox.Clear();
            levelBox.SelectedValue = 0;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
