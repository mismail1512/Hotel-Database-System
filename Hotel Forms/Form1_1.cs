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
    public partial class W1_1 : KryptonForm
    {
        //Controller may;
        Controller may = new Controller();
        public W1_1()
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
            //int a, int b, string c, int d, string e, string f
            //@G_ID, @NID, @Sex, @Birth, @City
            int chocho_train = may.InsertGuest11(Username.Text, Convert.ToInt32(National_ID.Text) , Convert.ToInt32(National_ID.Text), comboBox1.Text,
                                                 Birth.Text, Adress.Text);
            if (chocho_train == 0){MessageBox.Show("not yet ya jyyy");}
            //string a, string b, string c, int d 
            //@mail, @username, @PASS, @ty
            int chocho_train_bella = may.InsertUser11(Mail.Text, Username.Text, Passward.Text, "1");
                if (chocho_train_bella == 0) { MessageBox.Show("not yet ya bt"); }

            int chocho_train_bella2 = may.InsertG_phones11(Convert.ToInt32(National_ID.Text), Convert.ToInt32(Phone.Text));
                if (chocho_train_bella2 == 0) { MessageBox.Show("not yet ya aabyytaaa"); }
            if ((chocho_train != 0) & (chocho_train_bella != 0) & (chocho_train_bella2 != 0))
            {
                MessageBox.Show("Done! and Welcome!");
                Mail.Clear();
                National_ID.Clear();
                Username.Clear();
                Passward.Clear();
                Birth.Clear();
                Adress.Clear();
                //comboBox1.Dispose();
                Phone.Clear();
            }

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

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            W1 v = new W1();
            v.Show();
            this.Close();

        }
    }
}
