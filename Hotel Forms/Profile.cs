using BunifuAnimatorNS;
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
    public partial class Profile : Form
    {
        private readonly Controller Controller;
        public Profile()
        {
            InitializeComponent();
            //controller = new Controller();

            Controller = new Controller();
            DataTable dt1 = Controller.GetCurrentOrder();
            dataGridView1.DataSource = dt1;
            dataGridView1.Refresh();
            DataTable dt = Controller.GetCustomerData();
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();

           /* string[] row = new string[] {  "Room", "X" };
            dataGridView1.Rows.Add(row);
            row = new string[] {  "Gym", "Y" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "Restaurant", "Z" };
            dataGridView1.Rows.Add(row);


             row = new string[] { "Room", "X" };
            dataGridView2.Rows.Add(row);
            row = new string[] { "Gym", "Y" };
            dataGridView2.Rows.Add(row);
            row = new string[] { "Restaurant", "Z" };
           // dataGridView2.Rows.Add(row);
         //   dataGridView2.DataSource = controller.GetCustomerData();*/

        
           
        
    }
        private Form activeForm;
        private void Hideform(Form Opthionform, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = Opthionform;
            Opthionform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;

            Opthionform.Close();



        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void End_Click(object sender, EventArgs e)
        {
            Hideform(new menue(), sender);

            Form m = new W1();
            m.Show();
            this.Hide();
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
            int x = Controller.DeleteCurrentOrder();
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }
    }
}
