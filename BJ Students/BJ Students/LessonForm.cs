using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJ_Students
{
    public partial class LessonForm : Form
    {
        public BindingList<Lesson> lessons = new BindingList<Lesson>();
        public List<Student> attend = new List<Student>();
        public List<Student> absent = new List<Student>();
        DateTime date = new DateTime();
        public Lesson selected;
        public Lesson selectedItem;
        public BindingList<Student> allStudents = new BindingList<Student>();
        public Student selection;
        public BindingList<Student> classStudents = new BindingList<Student>();
        public List<Lesson> displayLessons = new List<Lesson>();

        private BinaryFormatter formatter = new BinaryFormatter();
        private const string DATA_FILENAME = "lessoninfo.dat";
        private const string DATA_BACKUP = "lessoninfobackup.dat";

        //DONE - Accept students from the main form so that it can be passed to the lesson form
        public LessonForm(BindingList<Student> students)
        {
            InitializeComponent();
            Lesson lesson = new Lesson(-1, "", "", -1, -1, "", "", attend);
            allStudents = students;
            LoadData();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            bool edit = false;
            CreateLesson createLesson = new CreateLesson(lessons, edit);
            createLesson.ShowDialog();
            Global.changes = true;
            RefreshList();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            bool edit = true;
            int curIndex = -1;
            if (lessonBox.SelectedIndex != -1)
                curIndex = lessonBox.SelectedIndex;
            if (lessonBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Lesson");
                return;
            }
            selected = lessons[curIndex];
            CreateLesson createLesson = new CreateLesson(lessons, edit, selected);
            createLesson.ShowDialog();
            Global.changes = true;
            RefreshList();
            lessonBox.SelectedIndex = curIndex;
        }

        private void RefreshList()
        {
            displayLessons.Clear();
            foreach (Lesson l in lessons)
            {
                //lessonBox.DisplayMember = "Title";
                //lessonBox.ValueMember = "ID";
                //lessonBox.Items.Add(l);
                displayLessons.Add(l);
            }
            displayLessons = displayLessons.OrderBy(x => x.Day == "Saturday").ThenBy(x => x.Day == "Friday").ThenBy(x => x.Day == "Thursday").ThenBy(x => x.Day == "Wednesday").ThenBy(x => x.Day == "Tuesday").ThenBy(x => x.Day == "Monday").ToList();
            lessonBox.DisplayMember = "Title";
            lessonBox.ValueMember = "ID";
            lessonBox.DataSource = displayLessons;
        }

        private void lessonBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = (Lesson)lessonBox.SelectedItem;
            //moving code below causes a read/write error
            RefreshMembers();
            RefreshDetails();
        }

        private void RefreshMembers()
        {
            membersBox.Items.Clear();
            if (selected.Members == null)
                return;
            foreach (Student s in selected.Members)
            {
                membersBox.Items.Add(s);
                membersBox.DisplayMember = "FullName";
                membersBox.ValueMember = "ID";
            }
        }

        private void RefreshDetails()
        {
            lvlLbl.Text = selected.Lvl;
            teacherLbl.Text = selected.Teacher;
            roomLbl.Text = selected.Room;
            timeLbl.Text = selected.Hour.ToString() + ":" + selected.Minute.ToString().PadRight(2,'0');
        }

        //doesn't include backup or dialogue option; completely automated
        public void SaveData()
        {
            //This code will be replaced by the backup option
            /*
            DialogResult overwriteBox = new DialogResult();
            if (File.Exists(DATA_FILENAME))
            {
                overwriteBox = MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNo);
            }
            if (overwriteBox == DialogResult.No)
                return;
            */
            try
            {
                FileStream writerStream = new FileStream(DATA_FILENAME, FileMode.Create, FileAccess.Write);
                formatter.Serialize(writerStream, lessons);
                writerStream.Close();
                //MessageBox.Show("Save Complete");
                Global.changes = false;
            }
            catch
            {
                MessageBox.Show("Error saving file.");
            }
        }

        public void LoadData()
        {
            try
            {
                if (File.Exists(DATA_FILENAME))
                {
                    FileStream readerFileStream = new FileStream(DATA_FILENAME, FileMode.Open, FileAccess.Read);
                    lessons = (BindingList<Lesson>)formatter.Deserialize(readerFileStream);
                    RefreshList();
                    readerFileStream.Close();
                }
                else
                {
                    MessageBox.Show("No data file detected.");
                }
            }
            catch
            {
                MessageBox.Show("Error loading file.");
            }
        }

        private void LessonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void memberBtn_Click(object sender, EventArgs e)
        {
            Lesson lesson = (Lesson)lessonBox.SelectedItem;
            NewMember newMember = new NewMember(allStudents, lesson);
            newMember.ShowDialog();
            RefreshMembers();
        }

        private void LessonForm_Load(object sender, EventArgs e)
        {

        }

        private void deleteMBtn_Click(object sender, EventArgs e)
        {
            if (membersBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select Student");
                return;
            }
            if (lessonBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select Lesson");
                return;
            }
            Lesson lesson = (Lesson)lessonBox.SelectedItem;
            Student student = (Student)membersBox.SelectedItem;
            foreach (Student s in lesson.Members)
            {
                if (s.FullName == student.FullName)
                {
                    lesson.Members.Remove(student);
                    RefreshMembers();
                    break;
                }
            }
        }

        private void membersBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Lesson lesson = (Lesson)lessonBox.SelectedItem;
            lessons.Remove(lesson);
            RefreshList();
        }
    }
}
