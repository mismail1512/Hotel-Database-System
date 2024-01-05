﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Forms
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        Controller controllerObj;
        public Form2()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.getGuestsData();
            kryptonDataGridView1.DataSource = dt;
            kryptonDataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            W7_5 v = new W7_5();
            v.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            W7 v = new W7();
            v.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int r = 0;
            if (textBox1.Text == "")  //validation part
            {
                MessageBox.Show("Please, insert a Guest ID");
            }
            else
            {
                r = controllerObj.DeleteGuest(int.Parse(textBox1.Text));
                if (r == 0)
                {
                    MessageBox.Show("Deletion Failed!");
                }
                else if (r == 1)
                {
                    MessageBox.Show("Deletion Done!");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.getGuestsData();
            kryptonDataGridView1.DataSource = dt;
            kryptonDataGridView1.Refresh();
        }
    }
}
