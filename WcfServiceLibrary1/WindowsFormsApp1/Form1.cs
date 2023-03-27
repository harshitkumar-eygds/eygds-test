using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();

            int result = obj.addition(int.Parse(textBox1.Text), int.Parse(textBox2.Text));

            label3.Text = result.ToString();
        }
    }
}
