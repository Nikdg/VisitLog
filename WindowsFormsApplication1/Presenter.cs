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
        Employee employee;
        Student student;
        Visitor visitor;
        public Presenter(IView form)
        {
            this.form = form;
            record = new Record();
            //employee = new Employee();
            //student = new Student();
            //visitor = new Visitor();
            form.Writed += IndexIdentif;
        }
        void IndexIdentif(object sender, EventArgs e)
        {
            switch (form.comboBox1.SelectedIndex)
            {
                case 0:
                    //employee.Name = form.textBox1.Text;
                    //employee.Surname = form.textBox2.Text;
                    //employee.Age = Int32.Parse(form.textBox3.Text);
                    //employee.EmployeePosition = form.textBox4.Text;
                    //employee.Subject = form.textBox5.Text;
                    employee = new Employee(form.textBox1.Text, form.textBox2.Text, Int32.Parse(form.textBox3.Text), form.textBox4.Text, form.textBox5.Text);
                    form.listBox1.Items.Add(WriteEmployee(employee));
                    break;
                case 1:
                    //student.Name = form.textBox1.Text;
                    //student.Surname = form.textBox2.Text;
                    //student.Age = Int32.Parse(form.textBox3.Text);
                    //student.Faculty = form.textBox4.Text;
                    //student.Specialty = form.textBox5.Text;
                    //student.Group = form.textBox6.Text;
                    student = new Student(form.textBox1.Text, form.textBox2.Text, Int32.Parse(form.textBox3.Text), form.textBox4.Text, form.textBox5.Text, form.textBox6.Text);
                    form.listBox1.Items.Add(WriteStudent(student));
                    break;
                case 2:
                    //visitor.Name = form.textBox1.Text;
                    //visitor.Surname = form.textBox2.Text;
                    //visitor.Age = Int32.Parse(form.textBox3.Text);
                    //visitor.GoalVisit = form.textBox4.Text;
                    visitor = new Visitor(form.textBox1.Text, form.textBox2.Text, Int32.Parse(form.textBox3.Text), form.textBox4.Text);
                    form.listBox1.Items.Add(WriteVisitor(visitor));
                    break;
            }
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
        public void Run()
        {
            form.Show();
        }
    }
}
