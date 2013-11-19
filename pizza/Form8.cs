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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.LightGreen;
            button1.BackColor = Color.Bisque;
            button2.BackColor = Color.Bisque;
            button3.BackColor = Color.Bisque;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectpizzaDataSet.balance' table. You can move, or remove it, as needed.
            this.balanceTableAdapter.Fill(this.projectpizzaDataSet.balance);

        }

        private void button3_Click(object sender, EventArgs e)
        { //clear balance

            projectpizzaDataSet ds = new projectpizzaDataSet();
            projectpizzaDataSetTableAdapters.balanceTableAdapter daCust = new projectpizzaDataSetTableAdapters.balanceTableAdapter();



            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
           this.balanceTableAdapter.Update(projectpizzaDataSet.balance);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //some code to printing
        }

    }
}
