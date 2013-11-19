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
    public partial class Form3 : Form
    {
        projectpizzaDataSet ds = new projectpizzaDataSet();
        projectpizzaDataSetTableAdapters.productsTableAdapter daCust = new projectpizzaDataSetTableAdapters.productsTableAdapter();

        public Form3()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.LightGreen;
            button1.BackColor = Color.Cornsilk;
            button2.BackColor = Color.Cornsilk;
            button3.BackColor = Color.Cornsilk;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectpizzaDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.projectpizzaDataSet.products);

        }

        private void button2_Click(object sender, EventArgs e)
        {
         daCust.Insert(textBox1.Text, Convert.ToDouble( textBox2.Text));
         this.productsTableAdapter.Fill(this.projectpizzaDataSet.products);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            daCust.Delete(textBox1.Text, Convert.ToDouble( textBox2.Text));
            this.productsTableAdapter.Fill(this.projectpizzaDataSet.products);
        }

      
    }
}
