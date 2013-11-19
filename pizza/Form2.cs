using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pizza
{ 
    public partial class Form2 : Form
    {
        public Form2()
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
     

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {  //to fill the texts

            projectpizzaDataSet ds = new projectpizzaDataSet();
            projectpizzaDataSetTableAdapters.customersTableAdapter daCust = new projectpizzaDataSetTableAdapters.customersTableAdapter();
            daCust.Fill(ds.customers);
            projectpizzaDataSet.customersRow dr = ds.customers.FindByTel_Numbers(textBox1.Text);
            //for (int i = 0; i < ds.customers.Count; i++)
            //{
            //    if (textBox1.Text == ds.customers[i].Tel_Numbers)
            //    {
            //        textBox2.Text = ds.customers[i].Name;
            //        break;
            //    }
            //    else textBox2.Text = "";
            if (dr != null)
            {
                textBox2.Text = dr.Name;
                textBox3.Text = dr.Address;
                textBox4.Text = dr.Post_code;
                textBox5.Text = dr.City;
                
            }
            else MessageBox.Show("No such customer.Create new or Search again.");
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        { //clear

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";           
            checkBox1.Checked = false;
            checkBox2.Checked = false;

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            
            projectpizzaDataSet ds = new projectpizzaDataSet();
            projectpizzaDataSetTableAdapters.customersTableAdapter daCust = new projectpizzaDataSetTableAdapters.customersTableAdapter();
            daCust.Fill(ds.customers);

            projectpizzaDataSet.customersRow dr = ds.customers.FindByTel_Numbers(textBox1.Text);
            
            try
            {  if(textBox1.Text != null && textBox2.Text != null && textBox3.Text !=null && textBox5.Text !=null) 
                daCust.Insert(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text); // to create new customer
            }
            catch (Exception ex)
            {
                MessageBox.Show("This customer already exist");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //BALANCE TABLE
            //balance open 
            projectpizzaDataSet ds = new projectpizzaDataSet();
           projectpizzaDataSetTableAdapters.balanceTableAdapter daCust = new projectpizzaDataSetTableAdapters.balanceTableAdapter();
           if (textBox1.Text == null || textBox6.Text==null)
           {
               MessageBox.Show("Telephone number or Price must fill first!");
           }
           else
           {
               string y = comboBox2.Text;
               int x = Convert.ToInt32(textBox1.Text);
               double p = Convert.ToDouble(textBox6.Text);
              
               daCust.Insert(x, y, p);
               textBox1.Text = "";
               textBox2.Text = "";
               textBox3.Text = "";
               textBox4.Text = "";
               textBox5.Text = "";
               textBox6.Text = "";
               checkBox1.Checked = false;
               checkBox2.Checked = false;
           }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectpizzaDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.projectpizzaDataSet.products);

        }

        public string Original_Tel_Numbers { get; set; }

        public string Original_Name { get; set; }

        public string Original_Address { get; set; }

        public string Original_City { get; set; }

        public string Original_Post_code { get; set; }

        private void button6_Click(object sender, EventArgs e)
        {
            projectpizzaDataSet ds = new projectpizzaDataSet();
            projectpizzaDataSetTableAdapters.customersTableAdapter daCust = new projectpizzaDataSetTableAdapters.customersTableAdapter();
            daCust.Fill(ds.customers);

            projectpizzaDataSet.customersRow dr = ds.customers.FindByTel_Numbers(textBox1.Text);
            if (dr != null && dr.Tel_Numbers == textBox1.Text)
            {
                daCust.Delete(Original_Tel_Numbers = textBox1.Text, Original_Name = textBox2.Text, Original_Address = textBox3.Text, Original_City = textBox4.Text, Original_Post_code = textBox5.Text);
               
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {   
            
            projectpizzaDataSet ds = new projectpizzaDataSet();
            projectpizzaDataSetTableAdapters.productsTableAdapter daCust = new projectpizzaDataSetTableAdapters.productsTableAdapter();
            daCust.Fill(ds.products);
            projectpizzaDataSet.productsRow dr = ds.products.FindByidproducts(comboBox2.Text);

            if (dr != null && dr.idproducts == comboBox2.Text && checkBox1.Checked)
            {
                
                double y = dr.price;
                y = y + 2.00;
                string fin = y.ToString();
                textBox6.Text = fin;

            }
            else
            {
                try
                {
                    string stat = dr.price.ToString();
                    textBox6.Text = stat;
                }
                catch (Exception ex)
                { }
                
            }
            

        }
    }
}
