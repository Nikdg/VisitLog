using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    interface IRecord
    {
        void RecordVisit(string name, string surname, int age, string employeePosition, string subject);
        void RecordVisit(string name, string surname, int age, string faculty, string specialty, string group);
        void RecordVisit(string name, string surname, int age, string goalVisit);
    }
}
