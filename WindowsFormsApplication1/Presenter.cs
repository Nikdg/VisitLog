using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Presenter : IPresenter
    {
        MainForm form;
        Record record;
        public Presenter()
        {

        }
        public Presenter(MainForm form, Record record)
        {
            this.form = form;
            this.record = record;
        }
        public void Run()
        {
            form.Show();
        }
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
