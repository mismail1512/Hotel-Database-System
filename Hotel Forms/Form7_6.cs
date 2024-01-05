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
    public partial class W7_6 : KryptonForm
    {
        Controller BB = new Controller();
        public W7_6()
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

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            char a;
            if ((comboBox3.Text == "IN")|| (comboBox3.Text == "in"))
            {
                a = 'i';
            }
            else
            {
                a = 'o';
            }
            //@FID, @Descriptions, @In_OR_Out, @Amount
            int chocho_train = BB.InsertFinance11(Convert.ToInt32(textBox1.Text),
                                                  textBox4.Text,
                                                  a,  //8
                                                  Convert.ToInt32(textBox2.Text)-Convert.ToInt32(textBox3.Text)); //11

            if (chocho_train == 0) { MessageBox.Show("not yet ya aabyytaaa"); }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            string b;
            if ((comboBox3.Text == "IN") || (comboBox3.Text == "in"))
            {
                b = "i";
            }
            else
            {
                b = "o";
            }
            //@FID, @Descriptions, @In_OR_Out, @Amount
            int chocho_train = BB.ModifyFinance11(Convert.ToInt32(textBox1.Text),
                                                  textBox4.Text,
                                                  b,  //8
                                                  Convert.ToInt32(textBox2.Text) - Convert.ToInt32(textBox3.Text)); //11

            if (chocho_train == 0) { MessageBox.Show("not yet ya aabyytaaa"); }

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
           
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click_1(object sender, EventArgs e)
        {
            Form5 v = new Form5();
            v.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            if (this.textBox5.Text == null)
            {
                this.kryptonButton3.Enabled = false;
                this.kryptonButton1.Enabled = true;
            }
            else if (this.textBox5.Text != null)
            {
                this.kryptonButton3.Enabled = true;
                this.kryptonButton1.Enabled = false;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            DataTable jhjh = BB.getOneFinance11(Convert.ToInt32(textBox5.Text));
            //var g = jhjh.Rows[0].Field<string>[1];
            string str1 = Convert.ToString(jhjh.Rows[0]["FID"]);
            string str2 = Convert.ToString(jhjh.Rows[0]["Descriptions"]);
            string str3 = Convert.ToString(jhjh.Rows[0]["In_OR_Out"]);
            string str4 = Convert.ToString(jhjh.Rows[0]["Amount"]);
            textBox1.Text = str1;
            textBox2.Text = str4;
            //textBox3.Text = str4;
            textBox4.Text = str2;
        }
    }
}
