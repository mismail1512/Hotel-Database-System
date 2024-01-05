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
    public partial class W7 : KryptonForm
    {
        Controller controllerObj;
        public W7()
        {
            InitializeComponent();
            controllerObj = new Controller();

            int r = controllerObj.CountStaff();
            label6.Text = r.ToString();

            int r1 = controllerObj.CountFinance();
            label8.Text = r1.ToString();

            int r2 = controllerObj.CountReception();
            label7.Text = r2.ToString();

            int r3 = controllerObj.CountGuests();
            label9.Text = r3.ToString();

            int a = controllerObj.GetTotalInputFinance();
            int b = controllerObj.GetTotalOutputFinance();
            int c = a-b;
            string[] row = new string[] { a.ToString(), b.ToString(), c.ToString() };
            dataGridView1.Rows.Add(row);

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
            Form1 v = new Form1();
            v.Show();
            this.Hide();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Form2 v = new Form2();
            v.Show();
            this.Hide();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Form5 v = new Form5();
            v.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {
           
        }
    }
}
