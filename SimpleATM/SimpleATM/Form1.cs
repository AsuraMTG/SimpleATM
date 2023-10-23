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
using System.Globalization;

namespace SimpleATM
{
    public partial class Form1 : Form
    {
        public string firstName = "Marton";
        public string surname = "Masznyik";
        public string cardType = "debit card";

        public long phoneNumber = 06302133142;
        public long cardNumber = 2313213132131233;
        public long bankAccountNumber = 1177307800469001;

        public int PIN = 1234;
        public int money = 1000;
        private int time = DateTime.Now.Hour;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString();
            label13.Text = DateTime.Now.ToString();
            label25.Text = DateTime.Now.ToString();
            label16.Text = "$" + Convert.ToString(money);
            label22.Text = "$" + Convert.ToString(money);
        }
        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
            textBox3.MaxLength = 4;
        }
        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            textBox4.MaxLength = 16;
        }
        private void label10_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == Convert.ToString(PIN) && textBox4.Text == Convert.ToString(cardNumber))
            {
                tabPage2.Show();
                tabPage1.Hide();
                label14.Text = "Masznyik Marton";
                label24.Text = "Masznyik Marton";
                label27.Text = "First name: " + firstName;
                label28.Text = "Surname: " + surname;
                label29.Text = "Phone number: " + Convert.ToString(phoneNumber);
                label30.Text = "Card number: " + Convert.ToString(cardNumber);
                label31.Text = "Card type: " + cardType;
                label32.Text = "Bank account number: " + Convert.ToString(bankAccountNumber);
            }
            else
                label11.Show();
        }
        private void pictureBox11_Click_1(object sender, EventArgs e)
        {
            if (textBox3.Text == Convert.ToString(PIN) && textBox4.Text == Convert.ToString(cardNumber))
            {
                tabPage2.Show();
                tabPage1.Hide();
                label14.Text = "Masznyik Marton";
                label24.Text = "Masznyik Marton";
                label27.Text = "First name: " + firstName;
                label28.Text = "Surname: " + surname;
                label29.Text = "Phone number: " + Convert.ToString(phoneNumber);
                label30.Text = "Card number: " + Convert.ToString(cardNumber);
                label31.Text = "Card type: " + cardType;
                label32.Text = "Bank account number: " + Convert.ToString(bankAccountNumber);
            }
            else
                label11.Show();
        }
        private void pictureBox22_Click(object sender, EventArgs e)
        {
            tabPage4.Show();
            tabPage2.Hide();
        }
        private void label21_Click(object sender, EventArgs e)
        {
            tabPage4.Show();
            tabPage2.Hide();
        }
        public Form1()
        {
            InitializeComponent();
            label2.Hide();
            label11.Hide();
            label9.BackColor = Color.Transparent;
        }
        private void label20_Click(object sender, EventArgs e)
        {
            tabPage1.Show();
            tabPage2.Hide();
            label11.Hide();
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            label14.Text = string.Empty;
            label24.Text = string.Empty;
        }
        private void pictureBox23_Click(object sender, EventArgs e)
        {
            tabPage1.Show();
            tabPage2.Hide();
            label11.Hide();
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            label14.Text = string.Empty;
            label24.Text = string.Empty;
        }
        private void label34_Click(object sender, EventArgs e)
        {
            tabPage2.Show();
            tabPage4.Hide();
        }
        private void pictureBox31_Click(object sender, EventArgs e)
        {
            tabPage2.Show();
            tabPage4.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {
             
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click_1(object sender, EventArgs e)
        {

        }
        private void label4_Click_1(object sender, EventArgs e)
        {

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {
        }
        private void label17_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox24_Click(object sender, EventArgs e)
        {

        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label25_Click(object sender, EventArgs e)
        {

        }
        private void label24_Click(object sender, EventArgs e)
        {

        }
        private void label26_Click(object sender, EventArgs e)
        {

        }
        private void label32_Click(object sender, EventArgs e)
        {

        }
        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox32_Click(object sender, EventArgs e)
        {

        }
        private void label35_Click(object sender, EventArgs e)
        {

        }

       
    }
}
