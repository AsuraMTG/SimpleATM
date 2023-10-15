using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SimpleATM
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
        public void Form2_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void newbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            var myForm1 = new Form1();
            myForm1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            TextWriter tw = new StreamWriter("BankAccounts.txt");
            String text = textBox1.Text;
            tw.WriteLine(text);
            label10.Text = text;
            tw.Close();
        }
    }
}
