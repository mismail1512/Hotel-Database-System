﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Hotel_Forms
{
    public partial class W7_5 : KryptonForm
    {
        Controller jy = new Controller();
        public W7_5()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void kryptonColorButton1_SelectedColorChanged(object sender, ColorEventArgs e)
        {

        }

        private void kryptonWrapLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            int chocho_train = jy.ModifyGuest11(textBox1.Text, Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox3.Text), comboBox1.Text,
                                                textBox8.Text, textBox4.Text);
            if (chocho_train == 0) { MessageBox.Show("not yet ya jyyy"); }
            
            int chocho_train_bella2 = jy.ModifyG_phones11(Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox5.Text));
            if (chocho_train_bella2 == 0) { MessageBox.Show("not yet ya aabyytaaa"); }

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            //int a, int b, string c, int d, string e, string f
            //@G_ID, @NID, @Sex, @Birth, @City
            int chocho_train = jy.InsertGuest11(textBox1.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox3.Text), comboBox1.Text,
                                                textBox8.Text, textBox4.Text);
            if (chocho_train == 0) { MessageBox.Show("not yet ya jyyy"); }
            //string a, string b, string c, int d 
            //@mail, @username, @PASS, @ty
            int chocho_train_bella = jy.InsertUser11(textBox11.Text, textBox1.Text, textBox2.Text, "1");
            if (chocho_train_bella == 0) { MessageBox.Show("not yet ya bt"); }

            int chocho_train_bella2 = jy.InsertG_phones11(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text));
            if (chocho_train_bella2 == 0) { MessageBox.Show("not yet ya aabyytaaa"); }

        }
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            
            Form2 v = new Form2();
            v.Show();
            this.Close();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
            if (this.textBox7.Text == null)
            {
                this.kryptonButton1.Enabled = true;
                this.kryptonButton3.Enabled = false;
            }
            else if (this.textBox7.Text != null)
            {
                this.kryptonButton1.Enabled = false;
                this.kryptonButton3.Enabled = true;
                textBox3.Enabled = false;
            }

        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            DataTable jhjh = jy.getOneGuest11(Convert.ToInt32(textBox7.Text));
            //var g = jhjh.Rows[0].Field<string>[1];
            string str1 = Convert.ToString(jhjh.Rows[0]["G_Name"]);
            string str2 = Convert.ToString(jhjh.Rows[0]["GID"]);
            string str3 = Convert.ToString(jhjh.Rows[0]["NID"]);
            string str4 = Convert.ToString(jhjh.Rows[0]["Sex"]);
            string str5 = Convert.ToString(jhjh.Rows[0]["Birth"]);
            string str6 = Convert.ToString(jhjh.Rows[0]["City"]);
            textBox1.Text = str1;
            textBox3.Text = str2;
            textBox4.Text = str6;
            textBox8.Text = str5;
        }
    }
}
