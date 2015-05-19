using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String service;
        String category;
        String result;
        private void checkButton_Click(object sender, EventArgs e)
        {
            WebService check = new WebService();
            result = check.callWebService("http://services.odata.org/Northwind/Northwind.svc/");
            if (result == "success")
            {
                statusbox.Text = "Successfully connected to webservice!!";
                statusbox.BackColor = Color.LightGreen;
                urlbox.ReadOnly = false;
                button1.Enabled = true;
                    
                ArrayList al = new ArrayList();
                Service sr = new Service();
                al = sr.getServices();
                
                if (al[0] != "ERROR")
                {
                    foreach (String s in al)
                    {
                        serviceList.Items.Add(s);
                    }
                }
                else
                {
                    statusbox.Text = al[1].ToString();
                    statusbox.BackColor = Color.Red;
                }

                urlbox.Text = "http://services.odata.org/Northwind/Northwind.svc/Products?$orderby=ProductName";
            }
            else
            {
                statusbox.Text = "Failed to connect webservice! Please check internet connection or call system administrator.";
                statusbox.BackColor= Color.Red;
            }
            
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            WebService ws = new WebService();
            String result= ws.callWebService(urlbox.Text);
            if (result == "success")
            {
                Data da = new Data();
                ArrayList al = new ArrayList();
                al = da.getdata();

                if (al[0] == "success")
                {
                    statusbox.Text = "Successfully retrived data from webservice!";
                    statusbox.BackColor = Color.LightGreen;
                    dataGridView1.DataSource = al[1];
                }
                else
                {
                    statusbox.Text = al[0].ToString();
                    statusbox.BackColor = Color.Red;
                }
            }
            else
            {
                statusbox.Text = "Failed to connect webservice! Check the URL.";
                statusbox.BackColor = Color.Red;
            }

        }
        private void serviceList_SelectedIndexChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            categoryList.Items.Clear();
           
            service = serviceList.SelectedItem.ToString();
            WebService wb = new WebService();
            wb.callWebService("http://services.odata.org/Northwind/Northwind.svc/"+service);
           
            ArrayList al = new ArrayList();
            Categories cat = new Categories();
            al = cat.getCategories();
            if (al.Count != 0)
            {
                if (al[0] != "ERROR")
                {
                    foreach (String s in al)
                    {
                        categoryList.Items.Add(s);
                    }
                }
                else
                {
                    statusbox.Text = al[1].ToString();
                    statusbox.BackColor = Color.Red;
                }
            }
            else
            {
                statusbox.Text = "No Data to display";
                statusbox.BackColor = Color.Orange;
            }

            
        }
        private void categoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            category = categoryList.SelectedItem.ToString();
            WebService ws = new WebService();
            string result =  ws.callWebService(service,category);
            if (result == "success")
            {
                Data da = new Data();
                ArrayList al = new ArrayList();
                al = da.getdata();
                if (al[0] == "success")
                {
                    statusbox.Text = "Successfully retrived data from webservice!";
                    statusbox.BackColor = Color.LightGreen;
                    dataGridView1.DataSource = al[1];
                }
                else
                {
                    statusbox.Text = al[0].ToString();
                    statusbox.BackColor = Color.Red;
                }
            }
            else
            {
                statusbox.Text = "Failed to connect webservice!";
                statusbox.BackColor = Color.Red;

            }

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void urlbox_TextChanged(object sender, EventArgs e)
        {

        }

      

        




       

        

    }
}
