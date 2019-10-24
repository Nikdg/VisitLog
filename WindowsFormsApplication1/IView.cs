using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public interface IView
    {
        void WriterEmployee(Employee _employee);
        void WriterStudent(Student _student);
        void WriterVisitor(Visitor _visitor);
    }
}
