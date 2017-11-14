using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ClassLibrary1 { 
    [DataContract]
    public class Student
    {
        [DataMember]
        public string name;
        [DataMember]
        public string surname;
        [DataMember]
        public string address;
        [DataMember]
        public int telNumb;

        public Student(string name, string surname, string address, int telNumb)
        {
            name = this.name;
            surname = this.surname;
            address = this.address;
            telNumb = this.telNumb;
        }
    }

    class Subject
    {
        public string name;
        public string teacher;
        public int hours;

        public Subject(string name, string teacher, int hours)
        {
            name = this.name;
            teacher = this.teacher;
            hours = this.hours;
        }
    }

    class Group
    {
        public int stNum;
        public string mainTeach;

        public Group(int stNum, string mainTeach)
        {
            stNum = this.stNum;
            mainTeach = this.mainTeach;
        }
    }
}