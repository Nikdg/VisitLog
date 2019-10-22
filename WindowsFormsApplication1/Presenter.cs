using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Presenter
    {
        Record record = new Record();
        public string WriteEmployee(Employee rec)
        {
            return record.RecordVisit(rec.Name, rec.Surname,rec.Age, rec.EmployeePosition, rec.Subject );
        }
        public string WriteStudent(Student rec)
        {
            return record.RecordVisit(rec.Name, rec.Surname, rec.Age, rec.Faculty, rec.Specialty, rec.Group);
        }
        public string WriteVisitor(Visitor rec)
        {
            return record.RecordVisit(rec.Name, rec.Surname, rec.Age, rec.GoalVisit);
        }
    }
}
