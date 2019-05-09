using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJ_Students
{
    /// <summary>
    /// BJ CLUB 英会話 Software
    /// Designed by TJ Epperson
    /// Version 1.1.2
    /// </summary>

    /// <summary>
    /// Change Requests
    /// 
    /// DONE    Weekly lesson summaries for writing content on the board
    /// NET     Networking for shared files and updates
    /// PORT    Apple application (iPad)
    /// </summary>
        
    /// <summary>
    /// Version 1.1.2 Change Log
    /// 
    /// FEA     Summaries are available from the schedule form and will display absences and make-ups for the week
    /// FEA     Schedule UI will now display trial students separately
    /// QOL     Schedules will close and save automatically 
    /// QOL     Make-ups are now tracked separately in the schedule interface
    /// QOL     Errors will be followed with exception information for developers
    /// QOL     Form titles have been updated (mostly proper spacing)
    /// QOL     Selecting a summary will revert the schedule selection back to the original Monday after
    /// QOL     Schedule summaries will now be sorted by schedule time
    /// COD     LessonInstance objects now track make-ups in a separate Student object list
    /// COD     LessonInstance objects now track trials in a separate Student object list
    /// COD     Activating summary on any Monday will auto-select weekdays to generate objects as needed
    /// COD     Catches have been assigned Exceptions
    /// </summary>
        
    /// <summary>
    /// Version 1.1.1 Change Log
    /// 
    /// FIX     Opening schedule now properly displays the current day's lessons
    /// FIX     Schedule now generates lessons for the current day if none have been generated yet
    /// TMP     Future dates no longer show lessons from other days
    /// </summary>
        
    /// <summary>
    /// Version 1.0.1 Change Log
    /// QOL     Loading is now automatic if there is an existing save file
    /// QOL     Load confirmation has been removed
    /// QOL     Save changes dialog on closing only shows if there are changes
    /// QOL     Previous lessons will not update with newly added students
    /// QOL     Previous lessons will update student name changes without adding in new students
    /// QOL     Newly added students will automatically be added to present and future classes
    /// COD     Changes to GetEngLevel and GetLevelString for efficiency
    /// COD     If-else statements converted to conditional operations
    /// </summary>

    /// <summary>
    /// Version 1.1.0 Change Log
    /// COD     "changes" variable is now a global static variable
    /// FEA     Lessons can be created and tracked
    /// FEA     Calendar function can track individual classes, make-ups, and attendence
    /// QOL     Students added to lesson will automatically be added to calendar lessons
    /// QOL     All lists are now sorted alphabetically or by day where appropriate
    /// FEA     Lesson details are available in the lesson form
    /// </summary>

    /// <summary>
    /// Version 1.1.1 TO-DO List
    /// TODO    Clean up unused code
    /// TODO    Improve save dialogue and functions
    /// DONE    Prevent newly added students from appearing in old lessons
    /// TODO    Create a global backup system
    /// DONE    Add sorted lists or search options to member lists
    /// DONE    Sort lessons by day and improve display
    /// 
    /// 
    /// Version 1.1 TO-DO List
    /// DONE    Create Lesson class for storing lesson information
    /// DONE    Create form for creating and editing class information
    /// DONE    Assign students to classes via forms and methods
    /// DONE    Correct Student class to store lesson
    /// DONE    Create save/load for lessons
    /// DONE    Implement calendar system to track lessons
    /// DONE    Link this system to the original form and makeups
    /// WIP     Use null-coalescing operators where applicable
    /// WIP     Use |= operators where applicable
    /// </summary>

    public partial class Form1 : Form
    {
        public BindingList<Student> students = new BindingList<Student>();
        public List<string> makeup = new List<string>();
        private BinaryFormatter formatter = new BinaryFormatter();
        private const string DATA_FILENAME = "studentinfo.dat";
        private const string DATA_BACKUP = "studentinfobackup.dat";
        private const string LESSON_FILE = "lessoninfo.dat";
        public Student selected;
        public Student selectedItem;
        private List<Student> studentsList = new List<Student>();
        //public static bool changes; //DONE - make this a static global variable that can be changed from other forms

        public Form1()
        {
            InitializeComponent();
            Student student = new Student(-1, "", "", 0, "", makeup, -1, -1, -1, -1, "");
        }

        //list addition method - Primarily in CreateStudent, this code wasn't even being called anywhere
        //id code is written here but it is actually calculated in CreateStudent, so some inefficiency here
        //public void AddStudent(string fName, string lName, int enLvl, int speak, int listen, int read, int write, string note)
        //{
        //    int id = -1; //this value isn't actually used other than fulfilling arguments and passing and returning
        //    Student student = new Student(id, fName, lName, enLvl, makeup, speak, listen, read, write, note);
        //    students.Add(student);
        //}

        //list deletion method
        //will need some attention for maintaining id assigment protocol
        //the id assigned by index number will have to change in another method
        public void DeleteStudent(Student delRequest)
        {
            students.Remove(delRequest);
            MessageBox.Show("Student Deleted");
        }

        //update list method after addition/deletion
        //display members are used here and objects are stored directly into the list
        //this was a big mistake not storing them directly before
        public void RefreshList()
        {
            studentsList.Clear();
            //studentList.Items.Clear();

            foreach (Student s in students)
            {                
                studentsList.Add(s);
            }
            studentsList = studentsList.OrderBy(x => x.FirstName).ToList();
            studentList.DataSource = studentsList;
            studentList.DisplayMember = "FullName";
            studentList.ValueMember = "ID";
        }  

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        //update UI code was moved from SelectedIndexChanged to this and is called here
        public void UpdateUI()
        {
            selectedItem = (Student)studentList.SelectedItem;
            if (selectedItem == null)
                return;
            foreach (Student i in students)
            {
                if (selectedItem.ID == i.ID)
                {
                    fLbl.Text = i.FirstName;
                    lLbl.Text = i.LastName;
                    //lvlLbl.Text = GetLevelString(i.EnLvl);
                    lvlLbl.Text = LISC.GetLevelString(i.EnLvl);
                    mainClassLbl.Text = i.MainClass;
                    idLbl.Text = i.ID.ToString();

                    //take a look at conditional operators for if-else
                    muLbl1.Text = 0 < i.Makeup.Count ? i.Makeup[0] : "None";
                    //if (0 < i.Makeup.Count)
                    //    muLbl1.Text = i.Makeup[0];
                    //else muLbl1.Text = "None";

                    muLbl2.Text = 1 < i.Makeup.Count ? i.Makeup[1] : "None";

                    muLbl3.Text = 2 < i.Makeup.Count ? i.Makeup[2] : "None";

                    muLbl4.Text = 3 < i.Makeup.Count ? i.Makeup[3] : "None";

                    selected = i;
                }
            }
        }

        //update the details group when a new list item is selected
        //the selection system has been updated and objects are stored in the list properly
        public void studentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        //seems to be in order for serializing the binding list "students" and reloading it
        //this method was separated from the saveBtn_Click event to be called from elsewhere as well
        //recently added a backup option as well triggered from saving
        //the backup opens a second stream which seems unneccesary
        public void SaveData()
        {
            /*
            DialogResult overwriteBox = new DialogResult();
            if (File.Exists(DATA_FILENAME))
            {
                overwriteBox = MessageBox.Show("This will overwrite the current file.", "Overwrite File", MessageBoxButtons.OKCancel);
            }
            if (overwriteBox == DialogResult.Cancel)
                return;
            */
            try
            {
                FileStream writerStream = new FileStream(DATA_FILENAME, FileMode.Create, FileAccess.Write);
                formatter.Serialize(writerStream, students);
                writerStream.Close();
                Global.changes = false;
                
                //Take this backup saving code and create a new global backup option
                /*
                DialogResult makeBackup = MessageBox.Show("Do you want to create a backup?", "Backup", MessageBoxButtons.YesNo);
                if (makeBackup == DialogResult.Yes)
                {
                    FileStream backupStream = new FileStream(DATA_BACKUP, FileMode.Create, FileAccess.Write);
                    formatter.Serialize(backupStream, students);
                    backupStream.Close();
                    MessageBox.Show("Backup Created");
                }
                */
            }
            catch (Exception excp)
            {
                MessageBox.Show("Error saving file.");
                MessageBox.Show("Please report this error to the developer: " + excp.ToString());
            }
        }

        //this method was separated from loadBtn_Click event to be called elsewhere
        //also allows checks for load confirmation with a little more organization
        public void LoadData()
        {
            try
            {
                if (File.Exists(DATA_FILENAME))
                {
                    FileStream readerFileStream = new FileStream(DATA_FILENAME, FileMode.Open, FileAccess.Read);
                    students = (BindingList<Student>)formatter.Deserialize(readerFileStream);
                    RefreshList();
                    readerFileStream.Close();
                }
                else
                {
                    MessageBox.Show("No data file detected.");
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show("Error loading file.");
                MessageBox.Show("Please report this error to the developer: " + excp.ToString());
            }
        }

        //Seems to be in order for serializing the binding list "students" and reloading it
        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveData();
            MessageBox.Show("Data Saved");
        }

        public void loadBtn_Click(object sender, EventArgs e)
        {
            DialogResult wantLoad = MessageBox.Show("Do you want to load data?", "Load Confirmation", MessageBoxButtons.YesNo);
            if (wantLoad == DialogResult.Yes)
                LoadData();
        }

        //This will show a new dialog form for creating a new entry into the student list
        private void newBtn_Click_1(object sender, EventArgs e)
        {
            bool edit = false;
            CreateStudent createStudent = new CreateStudent(students, edit);
            createStudent.ShowDialog();
            Global.changes = true;
            RefreshList();
        }

        //this search system matches strings and updates lists with every text change
        //there are likely some better ways to run this, probably with lambda functions
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string search = searchBox.Text;
            List<Student> searchList = new List<Student>();
            searchList.Clear();
            foreach (Student s in students)
            {
                if (s.FirstName.ToLower().Contains(search.ToLower()) || s.LastName.ToLower().Contains(search.ToLower()))
                {
                    searchList.Add(s);
                }
            }
            //studentList.Items.Clear();
            //foreach (Student s in searchList)
            //{
            //    studentList.Items.Add(s);
            //}
            studentList.DataSource = searchList;
            if (searchBox.Text == "")
                RefreshList();
        }

        private void detailsBtn_Click(object sender, EventArgs e)
        {
            Details details = new Details(selected);
            try
            {
                details.Show();
            }
            catch (Exception excp)
            {
                MessageBox.Show("Unable to Open Details");
                MessageBox.Show("Please report this error to the developer: " + excp.ToString());
            }
        }

        //FINISHED: this code needs to be updated to reselect the proper index after editing or
        //perhaps even after creating a student
        private void editBtn_Click(object sender, EventArgs e)
        {
            bool edit = true;
            int curIndex = -1;
            if (studentList.SelectedIndex != -1)
                curIndex = studentList.SelectedIndex;
            CreateStudent createStudent = new CreateStudent(students, edit, selected);
            createStudent.ShowDialog();
            Global.changes = true;
            searchBox.Clear();
            RefreshList();
            studentList.SelectedIndex = curIndex;
        }

        //recently added a confirm deletion option to avoid accidental deletions
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirmDEL = MessageBox.Show("Are you sure you want to delete " + selected.FirstName + " " + selected.LastName + "?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (confirmDEL == DialogResult.Yes)
            {
                try
                {
                    DeleteStudent(selected);
                    Global.changes = true;
                }
                catch (Exception excp)
                {
                    MessageBox.Show("Unable to Delete");
                    MessageBox.Show("Please report this error to the developer: " + excp.ToString());
                }
                searchBox.Clear();
                RefreshList();
            }
            else return;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Global.changes)
            {
                DialogResult closeBox = MessageBox.Show("Do you want to close without saving changes?", "Save Check", MessageBoxButtons.YesNo);
                e.Cancel = (closeBox == DialogResult.No);
            }
        }

        private void classesBtn_Click(object sender, EventArgs e)
        {
            LessonForm lessonForm = new LessonForm(students);
            lessonForm.ShowDialog();
        }

        private void scheduleBtn_Click(object sender, EventArgs e)
        {
            SaveData();
            BindingList<Lesson> lessons = new BindingList<Lesson>();
            if (File.Exists(LESSON_FILE))
            {
                FileStream readerFileStream = new FileStream(LESSON_FILE, FileMode.Open, FileAccess.Read);
                lessons = (BindingList<Lesson>)formatter.Deserialize(readerFileStream);
                readerFileStream.Close();
            }
            Schedule schedule = new Schedule(lessons, students);
            schedule.ShowDialog();
        }
    }

    public static class Global
    {
        public static bool changes;
    }
}
