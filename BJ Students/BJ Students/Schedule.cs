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
using System.Globalization;

namespace BJ_Students
{
    public partial class Schedule : Form
    {
        public BindingList<LessonInstance> displayLesson = new BindingList<LessonInstance>();
        public BindingList<Lesson> allLessons = new BindingList<Lesson>();
        public BindingList<LessonInstance> allInstances = new BindingList<LessonInstance>();
        public BindingList<Student> allStudents;
        public const string file_name = "scheduleinfo.dat";
        private BinaryFormatter formatter = new BinaryFormatter();
        public DateTime dummyDate = new DateTime();
        public Student selectedStudent;
        public LessonInstance selectedLesson;
        public CalData cal = new CalData();
        public int lesIndex;

        public LessonInstance i1;
        public LessonInstance i2;
        public LessonInstance i3;

        public Schedule()
        {
            InitializeComponent();
            LoadDataset();
        }

        //Here's the code for working with the DataSet to save calendar information - WIP
        public void LoadDataset()
        {
            InitializeDataset();
            try
            {

            }
            catch
            {

            }
        }
        
        //DEPRECATED
        public void InitializeDataset()
        {
            cal.Appointments.Columns.Add("ID");
            cal.Appointments.Columns.Add("Level");
            cal.Appointments.Columns.Add("Day");
            cal.Appointments.Columns.Add("DateTime");
            cal.Appointments.Columns.Add("Teacher");
            cal.Appointments.Columns.Add("Room");
            cal.Appointments.Columns.Add("Members");
            cal.Appointments.Columns.Add("Attending");
            cal.Appointments.Columns.Add("Absent");
        }

        public Schedule(BindingList<Lesson> lessons, BindingList<Student> students)
        {
            InitializeComponent();
            LoadDataset();
            LoadData();
            allLessons = lessons;
            allStudents = students;
            //CreateInstances();
        }

        public void CreateInstances()
        {
            /*
            foreach (Lesson l in allLessons)
            {
                DateTime date = new DateTime();
                date = DateTime.Now;
                while (date.DayOfWeek.ToString() != l.Day)
                {
                    date = date.AddDays(1);
                }
                List<Student> absent = new List<Student>();
                List<Student> attend = new List<Student>();
                foreach (Student s in l.Members)
                {
                    attend.Add(s);
                }

                i1 = new LessonInstance(allInstances.Count + 1, l.Lvl, l.Day, l.Hour, l.Minute, date, l.Teacher, l.Room, l.Members, attend, absent);
                foreach (CalData.AppointmentsRow r in cal.Appointments)
                {
                    if (r.)
                }
                cal.Appointments.Rows.Add(1, i1.ID, i1.Lvl, i1.Day, i1.LessonTime, i1.Teacher, i1.Members, i1.Attend, i1.Absent);
            }
            */

            /*
            foreach (Lesson l in allLessons)
            {
                DateTime date = new DateTime();
                date = DateTime.Now;
                while (date.DayOfWeek.ToString() != l.Day)
                {
                    date = date.AddDays(1);
                }
                List<Student> absent = new List<Student>();
                List<Student> attend = new List<Student>();
                foreach (Student s in l.Members)
                {
                    attend.Add(s);
                }
                i1 = new LessonInstance(allInstances.Count + 1, l.Lvl, l.Day, l.Hour, l.Minute, date, l.Teacher, l.Room, l.Members, attend, absent);

                bool exists = false;
                foreach (LessonInstance p in allInstances)
                {
                    if (p.LessonTime.Day == i1.LessonTime.Day && p.ID == i1.ID)
                    {
                        exists = true;
                    }
                }
                if (!exists)
                {
                    allInstances.Add(i1);
                    cal.Appointments.Rows.Add(1, i1.ID, i1.Lvl, i1.Day, i1.LessonTime, i1.Teacher, i1.Members, i1.Attend, i1.Absent);
                }
                date = date.AddDays(7);
                List<Student> absent2 = new List<Student>();
                List<Student> attend2 = new List<Student>();
                foreach (Student s in l.Members)
                {
                    attend2.Add(s);
                }
                i2 = new LessonInstance(allInstances.Count + 1, l.Lvl, l.Day, l.Hour, l.Minute, date, l.Teacher, l.Room, l.Members, attend2, absent2);
                allInstances.Add(i2);
                date = date.AddDays(7);
                List<Student> absent3 = new List<Student>();
                List<Student> attend3 = new List<Student>();
                foreach (Student s in l.Members)
                {
                    attend3.Add(s);
                }
                i3 = new LessonInstance(allInstances.Count + 1, l.Lvl, l.Day, l.Hour, l.Minute, date, l.Teacher, l.Room, l.Members, attend3, absent3);
                allInstances.Add(i3);
                date = date.AddDays(7);
                List<Student> absent4 = new List<Student>();
                List<Student> attend4 = new List<Student>();
                foreach (Student s in l.Members)
                {
                    attend4.Add(s);
                }
                LessonInstance i4 = new LessonInstance(allInstances.Count + 1, l.Lvl, l.Day, l.Hour, l.Minute, date, l.Teacher, l.Room, l.Members, attend4, absent4);
                allInstances.Add(i4);
            }
            */
        }

        //there was a big problem where I was setting references instead of independent instances
        //so instead of creating a new copy and saying copy = original, I need to say
        //new copy, foreach item in original, put into copy,  basically copying it piece by piece
        void scheduleCal_DateChanged(object sender, DateRangeEventArgs e)
        {
            CreateDayInstance();
            UpdateLesson();
            /*
            displayLesson.Clear();
            lessonBox.DisplayMember = "Title";
            lessonBox.ValueMember = "ID";

            foreach (LessonInstance l in allInstances)
            {
                //THIS CODE HAS A TEMP FIX TO AN UNDERLYING PROBLEM
                if (l.LessonTime.Day == scheduleCal.SelectionStart.Day && l.Day == scheduleCal.SelectionStart.DayOfWeek.ToString())
                {
                    displayLesson.Add(l);
                    lessonBox.DataSource = displayLesson;
                }
            }
            lessonBox.ClearSelected();
            */
        }

        void UpdateLesson()
        {
            displayLesson.Clear();
            lessonBox.DisplayMember = "Title";
            lessonBox.ValueMember = "ID";

            foreach (LessonInstance l in allInstances)
            {
                //THIS CODE HAS A TEMP FIX TO AN UNDERLYING PROBLEM
                if (l.LessonTime.Day == scheduleCal.SelectionStart.Day && l.Day == scheduleCal.SelectionStart.DayOfWeek.ToString())
                {
                    displayLesson.Add(l);
                    lessonBox.DataSource = displayLesson;
                }
            }
            lessonBox.ClearSelected();
            try
            {
                if (lesIndex <= lessonBox.Items.Count && lessonBox.Items.Count > 0)
                    lessonBox.SelectedIndex = lesIndex;
                else lessonBox.ClearSelected();
            }
            catch
            {

            }
        }

        //THIS is the primary instance creation method
        void CreateDayInstance()
        {
            foreach (Lesson l in allLessons)
            {
                if (scheduleCal.SelectionRange.Start.DayOfWeek.ToString() == l.Day)
                {
                    List<Student> absent = new List<Student>();
                    List<Student> attend = new List<Student>();
                    List<Student> makeup = new List<Student>();
                    List<Student> trial = new List<Student>();
                    foreach (Student s in l.Members)
                    {
                        attend.Add(s);
                    }
                    LessonInstance instance = new LessonInstance(l.ID, l.Lvl, l.Day, l.Hour, l.Minute, scheduleCal.SelectionStart, l.Teacher, l.Room, l.Members, attend, absent, makeup, trial);
                    bool exists = false;
                    //Check for a copy of the instance already by ID and day
                    foreach (LessonInstance li in allInstances)
                    {
                        if (li.ID == instance.ID && li.LessonTime.Day == instance.LessonTime.Day)
                            exists = true;
                    }
                    //If we are looking at a day in the past, do not create the instance
                    //if (DateTime.Compare(scheduleCal.SelectionRange.Start, DateTime.Now) > 0)
                    //{
                    //    if (!exists)
                    //        allInstances.Add(instance);
                    //}
                    if (!exists)
                        allInstances.Add(instance);
                    //If the instance exists already, check for any updates in the names
                    if (exists)
                    {
                        foreach (LessonInstance li in allInstances)
                        {
                            if (li.ID == instance.ID && li.LessonTime.Day == instance.LessonTime.Day)
                            {
                                if (li.Members != instance.Members)
                                {
                                    li.Members = instance.Members;
                                    foreach (Student s in li.Members)
                                    {
                                        bool sExists = false;
                                        foreach (Student absentS in li.Absent)
                                        {
                                            if (s.ID == absentS.ID)
                                                sExists = true;
                                            if (s.ID == absentS.ID && s.FullName != absentS.FullName)
                                            {
                                                absentS.FirstName = s.FirstName;
                                                absentS.LastName = s.LastName;
                                            }
                                        }
                                        foreach (Student attendS in li.Attend)
                                        {
                                            if (s.ID == attendS.ID)
                                                sExists = true;
                                            if (s.ID == attendS.ID && s.FullName != attendS.FullName)
                                            {
                                                attendS.FirstName = s.FirstName;
                                                attendS.LastName = s.LastName;
                                            }
                                        }
                                        //Only update for present or future classes
                                        if (DateTime.Compare(scheduleCal.SelectionRange.Start, DateTime.Now) >= 0)
                                        {
                                            if (!sExists)
                                                li.Attend.Add(s);
                                        }
                                        
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        void Schedule_Load(object sender, EventArgs e)
        {
            //scheduleCal.SelectionStart = DateTime.Now;    //This line caused an usual bug with reading Fridays
            scheduleCal.SelectionStart = DateTime.Today.AddDays(-1);
            scheduleCal.SelectionStart = DateTime.Today;
        }

        //doesn't include backup or dialogue option; completely automated
        public void SaveData()
        {
            DialogResult overwriteBox = new DialogResult();
            /*
            if (File.Exists(file_name))
            {
                overwriteBox = MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNo);
            }
            if (overwriteBox == DialogResult.No)
                return;
            */
            try
            {
                FileStream writerStream = new FileStream(file_name, FileMode.Create, FileAccess.Write);
                formatter.Serialize(writerStream, allInstances);
                writerStream.Close();
                //MessageBox.Show("Save Complete");
                Global.changes = false;
            }
            catch (Exception excp)
            {
                MessageBox.Show("Error saving file.");
                MessageBox.Show("Please report this error to the developer: " + excp.ToString());
            }
        }

        public void LoadData()
        {
            try
            {
                if (File.Exists(file_name))
                {
                    FileStream readerFileStream = new FileStream(file_name, FileMode.Open, FileAccess.Read);
                    allInstances = (BindingList<LessonInstance>)formatter.Deserialize(readerFileStream);
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

        private void absentBtn_Click(object sender, EventArgs e)
        {
            if (attendBox.SelectedIndex == -1 && makeupBox.SelectedIndex == -1 && trialBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Student");
                return;
            }
            if (attendBox.SelectedIndex != -1)
            {
                foreach (Student s in selectedLesson.Attend)
                {
                    if (selectedStudent.FullName == s.FullName && selectedLesson.LessonTime.Day == scheduleCal.SelectionStart.Date.Day)
                    {
                        selectedLesson.Absent.Add(s);
                        selectedLesson.Attend.Remove(s);
                        break;
                    }
                }
            }
            else if (makeupBox.SelectedIndex != -1)
            {
                foreach (Student s in selectedLesson.Makeup)
                {
                    if (selectedStudent.FullName == s.FullName && selectedLesson.LessonTime.Day == scheduleCal.SelectionStart.Date.Day)
                    {
                        selectedLesson.Makeup.Remove(s);
                        break;
                    }
                }
            }
            else if (trialBox.SelectedIndex != -1)
            {
                foreach (Student s in selectedLesson.Trial)
                {
                    if (selectedStudent.FullName == s.FullName && selectedLesson.LessonTime.Day == scheduleCal.SelectionStart.Date.Day)
                    {
                        selectedLesson.Trial.Remove(s);
                        break;
                    }
                }
            }

            UpdateLesson();
            RefreshAttendAbsent();
        }

        private void makeupBtn_Click(object sender, EventArgs e)
        {
            if (lessonBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Lesson");
                return;
            }
            NewMakeup newMakeup = new NewMakeup(allStudents, selectedLesson);
            newMakeup.ShowDialog();
            UpdateLesson();
            RefreshAttendAbsent();
        }

        private void lessonBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lessonBox.SelectedIndex != -1)
            {
                selectedLesson = (LessonInstance)lessonBox.SelectedItem;
                lesIndex = lessonBox.SelectedIndex;
            }
            RefreshAttendAbsent();
        }

        private void RefreshAttendAbsent()
        {
            attendBox.Items.Clear();
            absentBox.Items.Clear();
            makeupBox.Items.Clear();
            trialBox.Items.Clear();
            if (selectedLesson.Attend != null && lessonBox.SelectedIndex != -1)
            {
                foreach (Student s in selectedLesson.Attend)
                {
                    attendBox.Items.Add(s);
                    attendBox.DisplayMember = "FullName";
                    attendBox.ValueMember = "ID";
                }
                foreach (Student s in selectedLesson.Absent)
                {
                    absentBox.Items.Add(s);
                    absentBox.DisplayMember = "FullName";
                    attendBox.ValueMember = "ID";
                }
                foreach (Student s in selectedLesson.Makeup)
                {
                    makeupBox.Items.Add(s);
                    makeupBox.DisplayMember = "FullName";
                    makeupBox.ValueMember = "ID";
                }
                foreach (Student s in selectedLesson.Trial)
                {
                    trialBox.Items.Add(s);
                    trialBox.DisplayMember = "FullName";
                    trialBox.ValueMember = "ID";
                }
            }
        }

        private void attendBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            absentBox.ClearSelected();
            makeupBox.ClearSelected();
            trialBox.ClearSelected();
            selectedStudent = (Student)attendBox.SelectedItem;
        }

        private void absentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            attendBox.ClearSelected();
            makeupBox.ClearSelected();
            trialBox.ClearSelected();
            selectedStudent = (Student)absentBox.SelectedItem;
        }

        private void attendBtn_Click(object sender, EventArgs e)
        {
            if (absentBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Student");
                return;
            }
            foreach (Student s in selectedLesson.Absent)
            {
                if (selectedStudent.FullName == s.FullName && selectedLesson.LessonTime.Day == scheduleCal.SelectionStart.Date.Day)
                {
                    selectedLesson.Attend.Add(s);
                    selectedLesson.Absent.Remove(s);
                    break;
                }
            }
            UpdateLesson();
            RefreshAttendAbsent();
        }

        private void Schedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void summaryBtn_Click(object sender, EventArgs e)
        {
            if (scheduleCal.SelectionStart.Date.ToString("dddd", new CultureInfo("en-US")) != "Monday")
            {
                MessageBox.Show("Please select a Monday");
                return;
            }
            DateTime day1 = scheduleCal.SelectionStart;
            DateTime day2 = scheduleCal.SelectionStart.AddDays(1);
            DateTime day3 = scheduleCal.SelectionStart.AddDays(2);
            DateTime day4 = scheduleCal.SelectionStart.AddDays(3);
            DateTime day5 = scheduleCal.SelectionStart.AddDays(4);
            DateTime day6 = scheduleCal.SelectionStart.AddDays(5);
            scheduleCal.SetDate(day2);
            scheduleCal.SetDate(day3);
            scheduleCal.SetDate(day4);
            scheduleCal.SetDate(day5);
            scheduleCal.SetDate(day6);
            scheduleCal.SetDate(day1);
            List<LessonInstance> summary = new List<LessonInstance>();
            foreach (LessonInstance l in allInstances)
            {
                if (l.LessonTime == day1 || l.LessonTime == day2 || l.LessonTime == day3 || l.LessonTime == day4 || l.LessonTime == day5 || l.LessonTime == day6)
                {
                    summary.Add(l);
                }
            }
            Summary sumForm = new Summary(summary);
            sumForm.ShowDialog();
        }

        private void trialBtn_Click(object sender, EventArgs e)
        {
            if (lessonBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Lesson");
                return;
            }
            NewTrial newTrial = new NewTrial(allStudents, selectedLesson);
            newTrial.ShowDialog();
            UpdateLesson();
            RefreshAttendAbsent();
        }

        /*
        private void trialBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            attendBox.ClearSelected();
            makeupBox.ClearSelected();
            absentBox.ClearSelected();
            selectedStudent = (Student)trialBox.SelectedItem;
        }

        private void makeupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            attendBox.ClearSelected();
            absentBox.ClearSelected();
            trialBox.ClearSelected();
            selectedStudent = (Student)makeupBox.SelectedItem;
        }
        */

        private void makeupBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            attendBox.ClearSelected();
            absentBox.ClearSelected();
            trialBox.ClearSelected();
            selectedStudent = (Student)makeupBox.SelectedItem;
        }

        private void trialBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            attendBox.ClearSelected();
            makeupBox.ClearSelected();
            absentBox.ClearSelected();
            selectedStudent = (Student)trialBox.SelectedItem;
        }
    }
}
