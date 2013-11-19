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
    public partial class Form7 : Form
    {

        projectpizzaDataSet ds = new projectpizzaDataSet();
        projectpizzaDataSetTableAdapters.usersTableAdapter daCust = new projectpizzaDataSetTableAdapters.usersTableAdapter();
        
        projectpizzaDataSet dss = new projectpizzaDataSet();
        projectpizzaDataSetTableAdapters.simuserTableAdapter daCusts = new projectpizzaDataSetTableAdapters.simuserTableAdapter();

        public Form7()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.LightGreen;
            button1.BackColor = Color.Bisque;
            button2.BackColor = Color.Bisque;
            button3.BackColor = Color.Bisque;
            button4.BackColor = Color.Bisque;
            button5.BackColor = Color.Bisque;
            button6.BackColor = Color.Bisque;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                daCust.Insert(textBox1.Text, textBox2.Text);
                MessageBox.Show("This manager has created successfull", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry! This manager already exist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            daCusts.Delete(Original_idusers = textBox1.Text, Original_password = textBox2.Text);
            MessageBox.Show("This user has deleted successfull", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
           
        }

        public string Original_idusers { get; set; }

        public string Original_password { get; set; }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                daCusts.Insert(textBox1.Text, textBox2.Text);
                MessageBox.Show("This user has created successfull", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry! This user already exist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            daCust.Delete(Original_idusers = textBox1.Text, Original_password = textBox2.Text);
            MessageBox.Show("This manager has deleted successfull", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form11 sd = new Form11();
             sd.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
