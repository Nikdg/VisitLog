using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Person
    {
        private string name;
        private string surname;
        private int age;
        public Person(string name,string surname,int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value>0 & value<105)
                {
                    age = value;
                }
                else
                {
                    age = 0;
                }

            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

    }
}
