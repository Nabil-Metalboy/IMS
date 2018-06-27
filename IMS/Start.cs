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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label8.Hide();
        }

        public Start(bool visibility)
        {
            InitializeComponent();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label8.Visible = visibility;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Registration newUserReg = new Registration();
            newUserReg.Show();
            this.Hide();

        }

        
    }
}
