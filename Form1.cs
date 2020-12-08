using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (FindErr())
            {
                textBox2.Text = "No Error";
            }
        }
        private bool FindErr()
        {
            try
            {
                int a = Int32.Parse(textBox1.Text);
                return true;
            }
            catch 
            {
                MessageBox.Show("Error");
                return false;
            }
        }
    }
}
