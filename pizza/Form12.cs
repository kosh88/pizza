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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.LightGreen;
            button2.BackColor = Color.Bisque;
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectpizzaDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.projectpizzaDataSet.products);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
