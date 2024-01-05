using System;
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
    public partial class W7_4 : KryptonForm
    {
        Controller may2 = new Controller();
        public W7_4()
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
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            //int a, int b, string c, int d, string e, string f, int g, string h, string j, string k, string l, int m, string n, int z, int x)
            //@S_ID, @NID, @Birth, @Salary, @Department, @Sex, @W_Shift, @SWD, @EWD, @City
            int chocho_train = may2.ModifyStaff11(textBox1.Text,
                                                  Convert.ToInt32(textBox7.Text), //1
                                                  Convert.ToInt32(textBox3.Text), //2
                                                  textBox8.Text,                  //3
                                                  Convert.ToInt32(textBox6.Text), //4
                                                  comboBox3.Text, //5
                                                  comboBox1.Text, //6                 
                                                  comboBox2.Text,  //8
                                                  textBox9.Text,                   //9
                                                  textBox10.Text,                   //10
                                                  textBox4.Text); //11

            int chocho_train_bella2 = may2.ModifyS_phones11(Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox5.Text));
            if (chocho_train_bella2 == 0) { MessageBox.Show("not yet ya aabyytaaa"); }

            if (chocho_train == 0) { MessageBox.Show("not yet"); }
            else { MessageBox.Show("peep peep "); }
            Form1 v = new Form1();
            v.Show();
            this.Close();

        }
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            
            //string z, int a, int b, string c, int d, string e, string f, int g, string h, string j, string k, string l)
            //@S_ID, @NID, @Birth, @Salary, @Department, @Sex, @W_Shift, @SWD, @EWD, @City
            int chocho_train = may2.InsertStaff11(textBox1.Text,
                                                  Convert.ToInt32(textBox7.Text), //1
                                                  Convert.ToInt32(textBox3.Text), //2
                                                  textBox8.Text,                  //3
                                                  Convert.ToInt32(textBox6.Text), //4
                                                  comboBox3.Text, //5
                                                  comboBox1.Text, //6
                                                  comboBox2.Text,  //8
                                                  textBox9.Text,                   //9
                                                  textBox10.Text,                   //10
                                                  textBox4.Text); //11
            
            int chocho_train_bella2 = may2.InsertS_phones11(Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox5.Text));
            if (chocho_train_bella2 == 0) { MessageBox.Show("not yet ya aabyytaaa"); }
            int chocho_train_bella = may2.InsertUser11(textBox11.Text, textBox1.Text, textBox2.Text, "2");
            if (chocho_train_bella == 0) { MessageBox.Show("not yet ya bt"); }

            
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Form1 v = new Form1();
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
                this.kryptonButton2.Enabled = false;
                this.kryptonButton1.Enabled = true;
            }
            else if (this.textBox7.Text != null)
            { 
                this.kryptonButton2.Enabled = true;
                this.kryptonButton1.Enabled = false;
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            



        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            DataTable jhjh = may2.getOneStaff11(Convert.ToInt32(textBox7.Text));
            //var g = jhjh.Rows[0].Field<string>[1];
            string str1 = Convert.ToString(jhjh.Rows[0]["S_Name"]);
            string str2 = Convert.ToString(jhjh.Rows[0]["SID"]);
            string str3 = Convert.ToString(jhjh.Rows[0]["NID"]);
            string str4 = Convert.ToString(jhjh.Rows[0]["Birth"]);
            String str5 = Convert.ToString(jhjh.Rows[0]["Salary"]);
            string str6 = Convert.ToString(jhjh.Rows[0]["Department"]);
            String str7 = Convert.ToString(jhjh.Rows[0]["Sex"]);
            String str8 = Convert.ToString(jhjh.Rows[0]["W_Shift"]);
            String str9 = Convert.ToString(jhjh.Rows[0]["SWD"]);
            String str10 = Convert.ToString(jhjh.Rows[0]["EWD"]);
            String str11 = Convert.ToString(jhjh.Rows[0]["City"]);
            textBox1.Text = str1;
            textBox3.Text = str3;
            textBox4.Text = str11;
            textBox8.Text = str4;
            textBox6.Text = str5;
            textBox9.Text = str9;
            textBox10.Text = str10;

        }
    }
}
