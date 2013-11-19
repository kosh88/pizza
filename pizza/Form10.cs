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
    public partial class Form10 : Form
    {
        projectpizzaDataSet ds = new projectpizzaDataSet();
        projectpizzaDataSetTableAdapters.announcementsTableAdapter daCust = new projectpizzaDataSetTableAdapters.announcementsTableAdapter();

        public Form10()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.LightGreen;
            button1.BackColor = Color.Bisque;
            button2.BackColor = Color.Bisque;
            button3.BackColor = Color.Bisque;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
      
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                this.announcementsTableAdapter.Insert(textBox1.Text);
                this.announcementsTableAdapter.Fill(this.projectpizzaDataSet.announcements);
            }
            catch (Exception ex)
            {
                MessageBox.Show("This announcement exist!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.announcementsTableAdapter.Delete(textBox1.Text);
            this.announcementsTableAdapter.Fill(this.projectpizzaDataSet.announcements);
        }

       

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectpizzaDataSet.announcements' table. You can move, or remove it, as needed.
            this.announcementsTableAdapter.Fill(this.projectpizzaDataSet.announcements);
            // TODO: This line of code loads data into the 'projectpizzaDataSet.announcements' table. You can move, or remove it, as needed.
            this.announcementsTableAdapter.Fill(this.projectpizzaDataSet.announcements);

        }
    }
}
