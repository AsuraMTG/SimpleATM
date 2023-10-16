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
using static System.Net.Mime.MediaTypeNames;

namespace SimpleATM
{
    public partial class Form2 : Form
    {
        public struct BankAccount
        {
            public int cardNumber;
            public string cardHolder;
            public string expirationDate;
            public int cvc;
        }
        public List<BankAccount> bankAccounts = new List<BankAccount>(5);
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
            /*
            TextWriter tw = new StreamWriter("BankAccounts.txt");
            String text = textBox1.Text;
            tw.WriteLine(text);
            label10.Text = text;
            tw.Close();
            */
            FileStream f = new FileStream("BankAccounts.txt", FileMode.Open);
            StreamReader sr = new StreamReader(f, Encoding.UTF8);
            BankAccount aktualis = new BankAccount();
            while (!sr.EndOfStream) 
            {
                string[] sor = sr.ReadLine().Split(' ');
                aktualis.cardNumber = Convert.ToInt32(sor[0]);
                aktualis.cardHolder = sor[1];
                aktualis.cardHolder += sor[2];
                aktualis.expirationDate = sor[3];
                aktualis.cvc = Convert.ToInt32(sor[4]);
                bankAccounts.Add(aktualis);
            }
            label10.Text = Convert.ToString(bankAccounts[0].cardNumber);
            label11.Text = Convert.ToString(bankAccounts[0].cardHolder); 
            label12.Text = Convert.ToString(bankAccounts[0].expirationDate); 
            label13.Text = Convert.ToString(bankAccounts[0].cvc); 
        }
    }
}
