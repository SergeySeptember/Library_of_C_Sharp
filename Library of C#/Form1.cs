using static Library_of_C_.Switch;

namespace Library_of_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = DoOperation(5, 5, Operation.Multiply).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee("Name", "Other");
            Person person = emp;
            Employee emp2 = (Employee)person;
        }
    }
}