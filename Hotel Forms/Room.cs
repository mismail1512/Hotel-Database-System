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
    public partial class Room : Form
    {
       // private readonly Controller Controller;
         Controller Controller;
        string TypeR;
        int nDays;
        int single = 100;
        int Double = 200;
        int suite = 500;
        int price;
        int Avail1;
        int Avail2;
        int Avail3;
        int RVID;
        DateTime Fromdate;
        DateTime Todate;
        int GID ;
        int FID ;
        string descriptions = "Request Room";
        char In_OR_Out = 'I';
        string gdr;
        public Room()
        { }
            
         public Room(string gdm)
         {
                InitializeComponent();
            Controller = new Controller();
            int A1 = /*Controller.GetSingleroomAvail();*/ 5;
            int A2 = /*Controller.GetDoubleroomAvail();*/5;
            int A3 = /*Controller.GetSuiteroomAvail();*/5;
             Avail1= A1;
             Avail2 = A2;
            Avail3 = A3;
            DateTime centuryBegin = new DateTime(2001, 1, 1);
            DateTime currentDate = DateTime.Now;
            string x1 = (currentDate.Hour).ToString();
            string x2 = currentDate.Second.ToString();
            string x3 = currentDate.Day.ToString();
            string x4 = currentDate.Month.ToString();
            //string x4 = (currentDate.Year - 2000).ToString();
            string RVID1 = "1" + x1 + x2 + x3 + x4;
             RVID = Int32.Parse(RVID1);
            Fromdate = dateTimePicker1.Value;
            Todate = dateTimePicker2.Value;
            FID = Int32.Parse("4" + RVID1);
            gdr = gdm;
            GID = /*Int16.Parse(gdr);*/5;


            if (Avail1 > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;


            }
            if (Avail2 > 0)
            {
                Doubl.Enabled = true;
            }
            else
            {
                Doubl.Enabled = false;

            }
            if (Avail3 > 0)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;

            }

         }
              

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void End_Click(object sender, EventArgs e)
        {
            Profile Profile = new Profile();
            Profile.Show();
            this.Close();
        }

        private void Single_Click(object sender, EventArgs e)
        {
            TypeR = "Single";
            Avail1 = Avail1 - 1;
            price = single;

        }


        private void Suite_Click(object sender, EventArgs e)
        {
            TypeR = "Suite";
            Avail3 = Avail3 - 1;
            price = suite;

        }

        private void Comfirm_Click(object sender, EventArgs e)
        {
            //  InsertRoom(int RVID, int TypeR, int nDays, int Avl1, int Avl2, int Avl3, int No)
            DateTime dt1 = dateTimePicker1.Value;
            string dtS1 = dt1.Year.ToString() + dt1.Month.ToString() + dt1.Day.ToString();
            DateTime dt2 = dateTimePicker2.Value;
            string dtS2 = dt2.Year.ToString() + dt2.Month.ToString() + dt2.Day.ToString();
            int dtI1 = Convert.ToInt32(dtS1);
            int dtI2 = Convert.ToInt32(dtS2);
            nDays = dtI2 - dtI1;
            Controller.InsertRoom3(RVID, TypeR, nDays, Avail1, Avail2, Avail3);
            Controller.InsertBooking_Room(RVID, GID, FID, Fromdate, Todate);

            Controller.InsertFinance(FID, descriptions, In_OR_Out, price);


            //if (r > 0 && r1 > 0 && r2 > 0)
            {
                MessageBox.Show("Room is booked successfully");
                Controller.InsertCurrentOrder(TypeR, price);

            }
            //else
            {
                //MessageBox.Show("Booking Failed");
            }
        }

        private void Room_Load(object sender, EventArgs e)
        {

        }

        private void Comfirm_Click_1(object sender, EventArgs e)
        {

        }

        private void D_Click(object sender, EventArgs e)
        {
            TypeR = "Double";
            Avail2 = Avail2 - 1;
            price = Double;
        }
    }

}
