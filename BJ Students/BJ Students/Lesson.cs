using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BJ_Students
{
    [Serializable]
    public class Lesson
    {
        public Lesson(int id, string lvl, string day, int hour, int minute, string teacher, string room, List<Student> members)
        {
            ID = id;                                                       //assigned incrementally, same as Student class
            Lvl = lvl;                                                     //lesson level
            Day = day;
            Hour = hour;
            Minute = minute;
            Teacher = teacher;                                             //teacher name
            Room = room;                                                   //room (green, red)
            Members = members;                                               //students attending, filled into a list or array
        }
        public int ID { get; set; }
        public string Lvl { get; set; }
        public string Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public string Time => Hour + ":" + Minute.ToString("D2");
        public string Teacher { get; set; }
        public string Room { get; set; }
        public List<Student> Members { get; set; }
        public virtual string Title => Day + " " + Lvl + " " + Time;
    }

    [Serializable]
    public class LessonInstance : Lesson
    {
        public LessonInstance(int id, string lvl, string day, int hour, int minute, DateTime lessonTime, string teacher, string room, List<Student> members, List<Student> attend, List<Student> absent, List<Student> makeup, List<Student> trial) : 
        base (id, lvl, day, hour, minute, teacher, room, members)
        {
            LessonTime = lessonTime;
            Absent = absent;
            Attend = attend;
            Makeup = makeup;
            Trial = trial;
        }
        
        public DateTime LessonTime { get; set; }
        public List<Student> Absent { get; set; }
        public List<Student> Attend { get; set; }
        public List<Student> Makeup { get; set; }
        public List<Student> Trial { get; set; }

        private int Count()
        {
            return Attend.Count + Makeup.Count + Trial.Count;
        }
        public override string Title => Day + " " + Lvl + " " + Time + " " + "(" + Count() + ")";
    }
}
