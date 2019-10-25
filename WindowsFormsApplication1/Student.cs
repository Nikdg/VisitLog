using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Student : Person
    {
        private string faculty;
        private string specialty;
        private string group;
        public Student()
        {

        }
        public Student(string name, string surname, int age, string faculty, string specialty, string group)
            :base(name,surname,age)
        {
            this.faculty = faculty;
            this.specialty = specialty;
            this.group = group;
        }
        public string Faculty
        {
            get
            {
                return faculty;
            }
            set
            {
                faculty = value;
            }
        }
        public string Specialty
        {
            get
            {
                return specialty;
            }
            set
            {
                specialty = value;
            }
        }
        public string Group
        {
            get
            {
                return group;
            }
            set
            {
                group = value;
            }
        }
    }
}
