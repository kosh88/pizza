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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.LightGreen;
            button1.BackColor = Color.Bisque;
            button2.BackColor = Color.Bisque;
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectpizzaDataSet.balance' table. You can move, or remove it, as needed.
            this.balanceTableAdapter.Fill(this.projectpizzaDataSet.balance);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
