using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WindowsFormsApplication1
{
    interface IRecord
    {
        string RecordVisit(string name, string surname, int age, string employeePosition, string subject);
        string RecordVisit(string name, string surname, int age, string faculty, string specialty, string group);
        string RecordVisit(string name, string surname, int age, string goalVisit);
    }
    public interface IPresenter
    {
        string Write(Employee rec);
        string Write(Student rec);
        string Write(Visitor rec);
    }
}
