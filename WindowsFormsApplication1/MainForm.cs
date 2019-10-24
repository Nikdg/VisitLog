using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form, IView
    {
        string name;
        string surname;
        int age;
        string employeePosition;
        string subject;
        string faculty;
        string specialty;
        string group;
        string goalVisit;
        Presenter presenter = new Presenter();
        Employee employee;
        Student student;
        Visitor visitor;
        public new void Show()
        {
            Application.Run(this);
        }
        public MainForm()
        {
            InitializeComponent();
            List<People> people = new List<People>
        {
            new People { Id=1, Name="Педагог"},
            new People { Id=2, Name="Студент"},
            new People { Id=3, Name="Гость"},
        };
            comboBox1.DataSource = people;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            People people = (People)comboBox1.SelectedItem;
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    textBox4.Visible = true;
                    label4.Visible = true;
                    label4.Text = "Должность";
                    textBox4.Width = 117; 
                    textBox5.Visible = true;
                    label5.Text = "Предмет";
                    textBox6.Visible = false;
                    label6.Visible = false;
                    break;
                case 1:
                    textBox4.Visible = true;
                    label4.Visible = true;
                    label4.Text = "Факультет";
                    textBox4.Width = 117;
                    textBox5.Visible = true;
                    label5.Text = "Специальность";
                    textBox6.Visible = true;
                    label6.Visible = true;
                    label6.Text = "Группа";
                    break;
                case 2:
                    textBox4.Visible = true;
                    textBox4.Width = 200;
                    label4.Visible = true;
                    label4.Text = "Цель визита";
                    textBox5.Visible = false;
                    label5.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    label6.Visible = false;
                    break;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            surname = textBox2.Text;
            age = Int32.Parse(textBox3.Text);
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    employeePosition = textBox4.Text;
                    subject = textBox5.Text;
                    WriterEmployee(employee);
                    listBox1.Items.Add(presenter.WriteEmployee(employee));
                    break;
                case 1:
                    faculty = textBox4.Text;
                    specialty = textBox5.Text;
                    group = textBox6.Text;
                    WriterStudent(student);
                    presenter.WriteStudent(student);
                    break;
                case 2:
                    goalVisit = textBox4.Text;
                    WriterVisitor(visitor);
                    presenter.WriteVisitor(visitor);
                    break;
            }
        }
        public void WriterEmployee(Employee _employee)
        {
            this.employee = _employee;
            employee = new Employee(name,surname,age,employeePosition,subject);
        }
        public void WriterStudent(Student _student)
        {
            this.student = _student;
            student = new Student(name, surname, age, faculty, specialty, group);
        }
        public void WriterVisitor(Visitor _visitor)
        {
            this.visitor = _visitor;
            visitor = new Visitor(name, surname, age, goalVisit);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
    class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
