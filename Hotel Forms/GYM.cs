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
    public partial class GYM : Form
    {
        Controller Controller;

        int No = 0;
        string nHours;
        int unitprice=50;
        int GyID;
        int GID ;
        int FID ;
        DateTime date = DateTime.Now;
        string descriptions = "Request GYM";
        char In_OR_Out = 'I';
        string gdg;
        public GYM()
        { }
            public GYM(string gdm)
            {
                InitializeComponent();
            Controller = new Controller();

            DateTime centuryBegin = new DateTime(2001, 1, 1);
            DateTime currentDate = DateTime.Now;
            string x1 = (currentDate.Hour).ToString();
            string x2 = currentDate.Second.ToString();
            string x3 = currentDate.Day.ToString();
            string x4 = currentDate.Month.ToString();
            string GID1 = "3" + x1 + x2 + x3 + x4;
            GyID = Int32.Parse(GID1);
            FID = Int32.Parse("4" + GID1);
            gdg = gdm;
            GID = /*Int16.Parse(gdg);*/5;

            }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Comfirm_Click(object sender, EventArgs e)
        {
            // public int InsertGym(int GID, int nHours, int AvlP, int No)

            if (c1.Checked == true)
            {
                No++;
                nHours = nHours +" & "+c1.Text;
            }

            if (c2.Checked == true)
            {
                No++;
                nHours = nHours + " & " + c2.Text;

            }

            if (c9.Checked == true)
            {
                No++;
                nHours = nHours + " & " + c9.Text;

            }

            if (c3.Checked == true)
            {
                No++;
                nHours = nHours + " & " + c3.Text;

            }

            if (c4.Checked == true)
            {
                No++;
                nHours = nHours + " & " + c4.Text;

            }

            if (c5.Checked == true)
            {
                No++;
                nHours = nHours + " & " + c5.Text;

            }

            if (c6.Checked == true)
            {
                No++;
                nHours = nHours + " & " + c6.Text;

            }

            if (c7.Checked == true)
            {
                No++;
                nHours = nHours + " & " + c7.Text;

            }

            if (c8.Checked == true)
            {
                No++;
                nHours = nHours + " & " + c8.Text;

            }

            Controller.InsertGym(GyID, nHours, No);
           
             Controller.InsertTraining( GyID,  GID,  FID,  date);

             Controller.InsertFinance(FID, descriptions, In_OR_Out, unitprice * No);

          //  if (r > 0 && r1 > 0 && r2 > 0)
           // {
                MessageBox.Show("GYM is booked successfully");
                 Controller.InsertCurrentOrder("GYM", unitprice*No);
          //  }
           // else
            //{
           //     MessageBox.Show("GYM Booking Failed");
           // }
        }

        private void End_Click(object sender, EventArgs e)
        {
           
            Profile Profile = new Profile();
            Profile.Show();
            this.Hide();
        }
    }
}
