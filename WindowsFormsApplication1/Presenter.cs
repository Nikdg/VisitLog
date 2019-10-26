using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Presenter : IPresenter
    {
        IView form;
        Record record;
        public Presenter(IView form)
        {
            this.form = form;
            record = new Record();

            form.Writed += IndexIdentif;
        }
        string IndexIdentif(object sender, int e)
        {
            switch (e)
            {
                case 0:
                    return Write((Employee)sender);
                case 1:
                    return Write((Student)sender);
                case 2:
                    return Write((Visitor)sender);
                default:
                    return "error";
            }
        }
        public string Write(Employee rec)
        {
            return record.RecordVisit(rec.Name, rec.Surname,rec.Age, rec.EmployeePosition, rec.Subject );
        }
        public string Write(Student rec)
        {
            return record.RecordVisit(rec.Name, rec.Surname, rec.Age, rec.Faculty, rec.Specialty, rec.Group);
        }
        public string Write(Visitor rec)
        {
            return record.RecordVisit(rec.Name, rec.Surname, rec.Age, rec.GoalVisit);
        }
    }
}
