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
           
                    button2.Visible = true;
                    this.button1.Hide();
         }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

        
 
