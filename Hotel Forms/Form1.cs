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
    public partial class W1 : KryptonForm
    {
        Controller controllerObj;
        public W1()
        {
            InitializeComponent();
            controllerObj = new Controller();
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

            if (textBox1.Text == "" || textBox2.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                string res = null;
                DataTable r = controllerObj.GetUserType(textBox1.Text.ToString(), textBox2.Text.ToString());
                if (r == null)
                {
                    MessageBox.Show("Login Failed, Please Try Again!");
                }
                else
                {
                    res = string.Join(Environment.NewLine, r.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));
                }
                if (res == "1")
                {
                    menue h = new menue();
                    h.Show();
                    this.Hide();
                }
                if (res == "2")
                {
                    W7 h = new W7();
                    h.Show();
                    this.Hide();
                }
                if (res == "3")
                {
                    Form8 h = new Form8();
                    h.Show();
                    this.Hide();
                }
                if (res == "4")
                {
                    Form9 h = new Form9();
                    h.Show();
                    this.Hide();
                }
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            W1_1 v = new W1_1();
            v.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            W1_2 v = new W1_2();
            v.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            W1_3 v = new W1_3();
            v.Show();
            this.Hide();
        }
    }
}
