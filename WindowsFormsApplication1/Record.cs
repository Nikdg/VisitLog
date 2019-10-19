using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WindowsFormsApplication1
{
    class Record : IRecord
    {
        string recVisit;
        public string RecordVisit(string name, string surname, int age, string employeePosition, string subject)
        {
            return recVisit = name + surname + age + employeePosition + subject;
        }
        public string RecordVisit(string name, string surname, int age, string faculty, string specialty, string group)
        {
            return recVisit = name + surname + age + faculty + specialty + group;
        }
        public string RecordVisit(string name, string surname, int age, string goalVisit)
        {
            return recVisit = name + surname + age + goalVisit;
        }
    }
}
