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
    public partial class MainForm : Form
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
        Employee employee;
        Student student;
        Visitor visitor;
        Presenter pr = new Presenter();
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
            if (comboBox1.SelectedIndex == 0 | comboBox1.SelectedIndex == 1)
            {
                textBox5.Visible = true;
            }
            else
            {
                textBox5.Visible = false;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                textBox6.Visible = true;
            }
            else
            {
                textBox6.Visible = false;
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
                    subject=textBox5.Text;
                    employee = new Employee(name, surname, age, employeePosition, subject);
                    listBox1.Items.Add(pr.WriteEmployee(employee));
                    break;
                case 1:
                    faculty = textBox4.Text;
                    specialty = textBox5.Text;
                    group = textBox6.Text;
                    student = new Student(name, surname, age, faculty, specialty,group);
                    listBox1.Items.Add(pr.WriteStudent(student));
                    break;
                case 2:
                    goalVisit = textBox4.Text;
                    visitor = new Visitor(name, surname, age, goalVisit);
                    listBox1.Items.Add(pr.WriteVisitor(visitor));
                    break;
            }
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
