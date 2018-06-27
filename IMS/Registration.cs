using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMS
{
    
    public partial class Registration : Form
    {
        sql insertQr = new sql();
        public Registration()
        {
            InitializeComponent();
            button2.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DataTable check = new DataTable();
            //check = insertQr.queryexecution("select * from USERINFO");
            //foreach(DataRow user in check.Rows)
            //{
            //    if (textBox1.Text == user["FirstName"].ToString()
            //        ||
            //        textBox2.Text == user["LastName"].ToString()
            //         ||
            //        textBox3.Text == user["UserName"].ToString()
            //         ||
            //        textBox4.Text == user["MobileNo"].ToString()
            //         ||
            //        textBox5.Text == user["Email"].ToString()
            //         ||
            //        textBox6.Text == user["Password"].ToString()

            //        ) 
            //    {
            //        MessageBox.Show("User Already Exists");
            //        Start st = new Start();
            //        st.Show();
            //        this.Hide();
            //    }

            //    else
            //    {
            //        MessageBox.Show("Data Verified");
            //        button2.Visible = true;
            //        this.button1.Hide();
            //    }
            //}
            button2.Visible = true;
            this.button1.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable user = new DataTable();
            user = insertQr.queryexecution("Insert into USERINFO (FirstName,LastName,UserName,MobileNo,Email,Password) values ('" + FNtextBox.Text +"','" + LNtextBox.Text + "','" + UNtextBox.Text + "','" + MobNotextBox.Text + "','"+EmailtextBox.Text+ "','" + PasstextBox.Text + "')");
            MessageBox.Show("User Registered Successfully");
        }
    }
}

        
 
