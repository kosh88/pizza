using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.BackColor = Color.Bisque;
            button2.BackColor = Color.Bisque;
            button3.BackColor = Color.Bisque;
            button4.BackColor = Color.Bisque;
            button5.BackColor = Color.Bisque;
            button6.BackColor = Color.Bisque;
            button7.BackColor = Color.Bisque;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form7 manage = new Form7();
            manage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 order = new Form2();
            order.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 balance = new Form8();
            balance.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 products = new Form3();
            products.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form10 anna = new Form10();
            anna.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 customers = new Form4();
            customers.Show();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Coral;
        }
    }
}
