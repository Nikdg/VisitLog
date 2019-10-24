using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WindowsFormsApplication1
{
    public class Record : IRecord
    {
        public Record()
        {

        }
        string recVisit;
        public string RecordVisit(string name, string surname, int age, string employeePosition, string subject)
        {
            return recVisit = name + " " + surname + " " + age + "лет " + employeePosition + " " + subject + " " + DateTime.Today;
        }
        public string RecordVisit(string name, string surname, int age, string faculty, string specialty, string group)
        {
            return recVisit = name + " " + surname + " " + age + "лет " + faculty + " " + specialty + " " + group;
        }
        public string RecordVisit(string name, string surname, int age, string goalVisit)
        {
            return recVisit = name + " " + surname + " " + age + "лет " + goalVisit;
        }
    }
}
