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
    public partial class CreateLesson : Form
    {
        public BindingList<Lesson> forCreation;
        bool edit_bool;
        public Lesson edit_selection;

        public CreateLesson(BindingList<Lesson> lessons, bool edit)
        {
            InitializeComponent();
            forCreation = lessons;
            edit_bool = edit;
        }

        public CreateLesson(BindingList<Lesson> lessons, bool edit, Lesson selected)
        {
            InitializeComponent();
            forCreation = lessons;
            edit_bool = edit;
            edit_selection = selected;
            UpdateEditUI(selected);
        }

        private BindingList<Lesson> CreateLesson_FormClosing(object sender, EventArgs eventArgs)
        {
            return forCreation;
        }

        public void UpdateEditUI(Lesson selected)
        {
            if (selected == null)
                return;
            teacherBox.Text = selected.Teacher;
            roomBox.Text = selected.Room;

            switch (selected.Lvl)
            {
                case "B0":
                    levelBox.SelectedIndex = 0;
                    break;

                case "B1":
                    levelBox.SelectedIndex = 1;
                    break;

                case "B2":
                    levelBox.SelectedIndex = 2;
                    break;

                case "IM1":
                    levelBox.SelectedIndex = 3;
                    break;

                case "IM2":
                    levelBox.SelectedIndex = 4;
                    break;

                case "AD1":
                    levelBox.SelectedIndex = 5;
                    break;

                case "AD2":
                    levelBox.SelectedIndex = 6;
                    break;
            }

            switch (selected.Teacher)
            {
                case "Terry":
                    teacherBox.SelectedIndex = 0;
                    break;

                case "Nathan":
                    teacherBox.SelectedIndex = 1;
                    break;

                case "Samantha":
                    teacherBox.SelectedIndex = 2;
                    break;
            }

            switch (selected.Room)
            {
                case "Red":
                    roomBox.SelectedIndex = 0;
                    break;

                case "Green":
                    roomBox.SelectedIndex = 1;
                    break;

                case "Orange":
                    roomBox.SelectedIndex = 2;
                    break;

                case "Blue":
                    roomBox.SelectedIndex = 3;
                    break;
            }

            switch (selected.Day)
            {
                case "Monday":
                    dayBox.SelectedIndex = 0;
                    break;

                case "Tuesday":
                    dayBox.SelectedIndex = 1;
                    break;

                case "Wednesday":
                    dayBox.SelectedIndex = 2;
                    break;

                case "Thursday":
                    dayBox.SelectedIndex = 3;
                    break;

                case "Friday":
                    dayBox.SelectedIndex = 4;
                    break;

                case "Saturday":
                    dayBox.SelectedIndex = 5;
                    break;
            }

            switch (selected.Hour)
            {
                case 11:
                    hourBox.SelectedIndex = 0;
                    break;

                case 12:
                    hourBox.SelectedIndex = 1;
                    break;

                case 13:
                    hourBox.SelectedIndex = 2;
                    break;

                case 14:
                    hourBox.SelectedIndex = 3;
                    break;

                case 15:
                    hourBox.SelectedIndex = 4;
                    break;

                case 16:
                    hourBox.SelectedIndex = 5;
                    break;

                case 17:
                    hourBox.SelectedIndex = 6;
                    break;

                case 18:
                    hourBox.SelectedIndex = 7;
                    break;

                case 19:
                    hourBox.SelectedIndex = 8;
                    break;

                case 20:
                    hourBox.SelectedIndex = 9;
                    break;
            }

            switch (selected.Minute)
            {
                case 00:
                    minuteBox.SelectedIndex = 0;
                    break;

                case 05:
                    minuteBox.SelectedIndex = 1;
                    break;

                case 10:
                    minuteBox.SelectedIndex = 2;
                    break;

                case 15:
                    minuteBox.SelectedIndex = 3;
                    break;

                case 20:
                    minuteBox.SelectedIndex = 4;
                    break;

                case 25:
                    minuteBox.SelectedIndex = 5;
                    break;

                case 30:
                    minuteBox.SelectedIndex = 6;
                    break;

                case 35:
                    minuteBox.SelectedIndex = 7;
                    break;

                case 40:
                    minuteBox.SelectedIndex = 8;
                    break;

                case 45:
                    minuteBox.SelectedIndex = 9;
                    break;

                case 50:
                    minuteBox.SelectedIndex = 10;
                    break;

                case 55:
                    minuteBox.SelectedIndex = 11;
                    break;
            }
        }

        public void AddLesson(int id, string lvl, string day, int hour, int minute, DateTime time, string teacher, string room, List<Student> members)
        {
            if (edit_bool == false)
            {
                Lesson lesson = new Lesson(id, lvl, day, hour, minute, teacher, room, members);
                forCreation.Add(lesson);
            }
            if (edit_bool)
            {
                foreach (Lesson l in forCreation)
                {
                    if (l.ID == edit_selection.ID) //DONE - add this passable argument from previous menu
                    {
                        l.Lvl = lvl;
                        l.Day = dayBox.Text;
                        l.Hour = Convert.ToInt32(hourBox.Text);
                        l.Minute = Convert.ToInt32(minuteBox.Text);
                        l.Teacher = teacher;
                        l.Room = room;
                        l.Members = members;
                    }
                }
            }
        }

        private void createBtn_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(teacherBox.Text))
            {
                MessageBox.Show("Please Select Teacher");
                return;
            }
            if (String.IsNullOrWhiteSpace(levelBox.Text))
            {
                MessageBox.Show("Please Select Level");
                return;
            }
            if (String.IsNullOrWhiteSpace(roomBox.Text))
            {
                MessageBox.Show("Please Select Room");
                return;
            }
            if (String.IsNullOrWhiteSpace(hourBox.Text))
            {
                MessageBox.Show("Please Select Hour");
                return;
            }
            if (String.IsNullOrWhiteSpace(minuteBox.Text))
            {
                MessageBox.Show("Please Select Minute");
                return;
            }

            int last = forCreation.Count - 1;
            int id = 0;
            if (last != -1)
                id = forCreation[last].ID + 1;
            DateTime lessonDate = new DateTime(); //empty
            List<Student> members = new List<Student>();
            AddLesson(id, levelBox.Text, dayBox.Text, Convert.ToInt32(hourBox.Text), Convert.ToInt32(minuteBox.Text), lessonDate, teacherBox.Text, roomBox.Text, members);

            this.Close();
            //DONE - check for empty/null values and prompt for input
            //DONE - add a level box to this form
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateLesson_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
