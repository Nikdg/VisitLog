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
        }
        class People
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
