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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.LightGreen;
            button1.BackColor = Color.Bisque;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectpizzaDataSet.announcements1' table. You can move, or remove it, as needed.
            this.announcements1TableAdapter.Fill(this.projectpizzaDataSet.announcements);

        }
    }
}
