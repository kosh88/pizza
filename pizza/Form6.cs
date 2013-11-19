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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.LightGreen;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 order = new Form2();
          order.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form13 balance = new Form13();
            balance.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 customers = new Form4();
            customers.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form12 products = new Form12();
            products.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 anna = new Form5();
            anna.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
