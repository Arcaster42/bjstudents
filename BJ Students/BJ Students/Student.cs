using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ_Students
{   [Serializable]
    public class Student
    {
        public Student(int id, string firstName, string lastName, int enLvl, string mainClass, List<string> makeup, int speak, int listen, int read, int write, string note)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EnLvl = enLvl;
            this.MainClass = mainClass;
            this.Makeup = makeup;
            this.Speak = speak;
            this.Listen = listen;
            this.Read = read;
            this.Write = write;
            this.Note = note;
        }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EnLvl { get; set; }
        public string MainClass { get; set; }
        public List<string> Makeup { get; set; }
        public int Speak { get; set; }
        public int Listen { get; set; }
        public int Read { get; set; }
        public int Write { get; set; }
        public string Note { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
    }
}
