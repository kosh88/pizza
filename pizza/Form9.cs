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
    public partial class Form9 : Form
    {

        public Form9()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            this.BackColor = System.Drawing.Color.Coral;
            button1.BackColor = Color.Bisque;
            button2.BackColor = Color.Bisque;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            projectpizzaDataSet ds = new projectpizzaDataSet();
            projectpizzaDataSetTableAdapters.usersTableAdapter daCust = new projectpizzaDataSetTableAdapters.usersTableAdapter();
            daCust.Fill(ds.users);
            projectpizzaDataSet.usersRow dr = ds.users.FindByidusers(textBox1.Text);

            projectpizzaDataSet dss = new projectpizzaDataSet();
            projectpizzaDataSetTableAdapters.simuserTableAdapter daCusts = new projectpizzaDataSetTableAdapters.simuserTableAdapter();
            daCusts.Fill(dss.simuser);
            projectpizzaDataSet.simuserRow drr = dss.simuser.FindByidsimuser(textBox1.Text);

            if ((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("You must fill the textboxes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                if (dr != null && dr.password == textBox2.Text)
                {
                    MessageBox.Show("You had successfully logged in as a Manager!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Form1 staff = new Form1();
                    staff.Show();
                }
                else if (drr != null && drr.password == textBox2.Text)
                {
                    MessageBox.Show("You had successfully logged in as a Simple User!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Form6 staff = new Form6();
                    staff.Show();

                }
                else
                {
                    MessageBox.Show("Invalid UserName or Password! Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }
        }
        

        private void Form9_Load(object sender, EventArgs e)
        {

        }

      
    }
}
