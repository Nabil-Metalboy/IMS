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
            DataTable check = new DataTable();
            check = insertQr.queryexecution("select * from USERINFO");
            foreach (DataRow user in check.Rows)
            {
                if (FNtextBox.Text == user["FirstName"].ToString()
                    ||
                    LNtextBox.Text == user["LastName"].ToString()
                     ||
                    UNtextBox.Text == user["UserName"].ToString()
                     ||
                    MobNotextBox.Text == user["MobileNo"].ToString()
                     ||
                    EmailtextBox.Text == user["Email"].ToString()
                    )
                {
                    MessageBox.Show("User Already Exists");
                    Start st = new Start(true);
                    st.Show();
                    this.Hide();
                }


                else 
                //if (FNtextBox.Text != user["FirstName"].ToString()
                //    ||
                //    LNtextBox.Text != user["LastName"].ToString()
                //     ||
                //    UNtextBox.Text != user["UserName"].ToString()
                //     ||
                //    MobNotextBox.Text != user["MobileNo"].ToString()
                //     ||
                //    EmailtextBox.Text != user["Email"].ToString())
                {
                    
                    button2.Visible = true;
                    this.button1.Hide();
                    
                }
                
            }
            MessageBox.Show("Data Verified");
            //button2.Visible = true;
            //this.button1.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable user = new DataTable();
            //Maal Dhukaite hobe avabe
            user = insertQr.queryexecution("Insert into USERINFO (FirstName,LastName,UserName,MobileNo,Email,Password) values ('" + FNtextBox.Text +"','" + LNtextBox.Text + "','" + UNtextBox.Text + "','" + MobNotextBox.Text + "','"+EmailtextBox.Text+ "','" + PasstextBox.Text + "')");
            MessageBox.Show("User Registered Successfully");
            FNtextBox.Clear();
            LNtextBox.Clear();
            UNtextBox.Clear();
            MobNotextBox.Clear();
            FNtextBox.Clear();
            EmailtextBox.Clear();
            PasstextBox.Clear();
        }
    }
}

        
 
