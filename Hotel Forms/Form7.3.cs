using System;
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
    public partial class Form5 : System.Windows.Forms.Form
    {
        Controller controllerObj;
        public Form5()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.getFinanceData();
            kryptonDataGridView1.DataSource = dt;
            kryptonDataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            W7_6 v = new W7_6();
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
                MessageBox.Show("Please, insert a Payment ID");
            }
            else
            {
                r = controllerObj.DeletePayment(int.Parse(textBox1.Text));
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
            DataTable dt = controllerObj.getFinanceData();
            kryptonDataGridView1.DataSource = dt;
            kryptonDataGridView1.Refresh();
        }
    }
}
