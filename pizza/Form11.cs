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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.LightGreen;
            button6.BackColor = Color.Bisque;
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectpizzaDataSet.simuser' table. You can move, or remove it, as needed.
            this.simuserTableAdapter.Fill(this.projectpizzaDataSet.simuser);
            // TODO: This line of code loads data into the 'projectpizzaDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.projectpizzaDataSet.users);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
