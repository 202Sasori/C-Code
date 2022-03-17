using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7.DAL
{
    internal class student
    {
        private string studentID, studentName, studentClass;
        public student() { }
        public student(string studentID, string studentName, string studentClass)
        {
            this.studentID = studentID;
            this.studentName = studentName;
            this.studentClass = studentClass;
        }

        public string ID { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
    }
}
