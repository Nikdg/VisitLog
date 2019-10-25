using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Employee : Person
    {
        private string employeePosition;
        private string subject;
        //public Employee()
        //{
       
        //}
        public Employee(string name, string surname, int age, string employeePosition, string subject)
            :base(name,surname,age)
        {
            this.employeePosition = employeePosition;
            this.subject = subject;
        }
        public string EmployeePosition
        {
            get
            {
                return employeePosition;
            }
            set
            {
                employeePosition = value;
            }
        }
        public string Subject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
            }
        }

    }
}
