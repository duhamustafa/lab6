using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary4;

namespace WindowsFormsApp2
{
    public partial class placeorderlbl : Form
    {
        public placeorderlbl()
        {
            InitializeComponent();
        }

        private void place_order_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (kurkurechk.Checked == true)
            {
                kurkuretxt.Enabled == true;
                kurkuretxt.Text = " ";


                if (kurkurechk.Checked == false)
                {
                    kurkuretxt.Enabled == false;
                    kurkuretxt.Text = "0 ";
                }
            }
        }

        private void kurkuretxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
