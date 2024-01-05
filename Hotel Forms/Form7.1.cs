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
    public partial class Form1 : System.Windows.Forms.Form
    {
        Controller controllerObj;
        public Form1()
        {
            InitializeComponent();
            controllerObj = new Controller();
            //DataTable dt = controllerObj.getStaffDatanew(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            DataTable dt = controllerObj.getStaffData();
            kryptonDataGridView1.DataSource = dt;
            kryptonDataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            W7 v = new W7();
            v.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            W7_4 v = new W7_4();
            v.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int r = 0;
            if (textBox1.Text == "")  //validation part
            {
                MessageBox.Show("Please, insert a Staff ID");
            }
            else
            {
                r = controllerObj.DeleteStaff(int.Parse(textBox1.Text));
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
            //DataTable dt = controllerObj.getStaffDatanew(dateTimePicker2.Value.Date, dateTimePicker1.Value.Date);
            DataTable dt = controllerObj.getStaffData();
            kryptonDataGridView1.DataSource = dt;
            kryptonDataGridView1.Refresh();
        }

    }
}
