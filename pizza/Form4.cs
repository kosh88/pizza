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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.LightGreen;
            button1.BackColor = Color.Bisque;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectpizzaDataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.projectpizzaDataSet.customers);

        }
    }
}
