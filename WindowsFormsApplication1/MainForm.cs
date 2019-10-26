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
    public delegate string Writing(object sender, int e);
    public partial class MainForm : Form, IView
    {
        public MainForm()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
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
        public event Writing Writed;

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
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Employee employee = new Employee(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text), textBox4.Text, textBox5.Text);
                    listBox1.Items.Add(Writed.Invoke(employee, comboBox1.SelectedIndex));
                    break;
                case 1:
                    Student student = new Student(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text), textBox4.Text, textBox5.Text, textBox6.Text);
                    listBox1.Items.Add(Writed.Invoke(student, comboBox1.SelectedIndex));
                    break;
                case 2:
                    Visitor visitor = new Visitor(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text), textBox4.Text);
                    listBox1.Items.Add(Writed.Invoke(visitor, comboBox1.SelectedIndex));
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
