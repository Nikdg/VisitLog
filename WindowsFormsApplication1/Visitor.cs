using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Visitor : Person
    {
        private string goalVisit;
        public Visitor(string name, string surname, int age, string goalVisit)
            : base(name, surname, age)
        {
            this.goalVisit = goalVisit;
        }
        public string GoalVisit
        {
            get
            {
                return goalVisit;
            }
            set
            {
                goalVisit = value;
            }
        }
    }
}
