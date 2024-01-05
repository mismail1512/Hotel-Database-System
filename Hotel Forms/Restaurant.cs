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

    public partial class Restaurant : Form
    {
         Controller Controller;

        string TypeT;
        string Order;
        int T_price = 0;
        int NO = 0;
        string TypeF = "single";
        int GID ;
        int FID ;
        DateTime date = DateTime.Now;
        int RSID;
        string descriptions = "Request Meal";
        char In_OR_Out = 'I';
        string gdres;
        public Restaurant()
        { }
            public Restaurant(string gdm)
            {
                InitializeComponent();
            Controller = new Controller();
            DateTime centuryBegin = new DateTime(2001, 1, 1);
            DateTime currentDate = DateTime.Now;
            string x1 = (currentDate.Hour).ToString();
            string x2 = currentDate.Second.ToString();
            string x3 = currentDate.Day.ToString();
            string x4 = currentDate.Month.ToString();
            //  string x1 = currentDate.Minute.ToString();

            //  date= Int32.Parse(x0 + x1 + x2 + x3 + x4);
            string RSID1 = "2"+ x1 + x2 + x3 + x4;
             RSID = Int32.Parse(RSID1);
             FID = Int32.Parse("4"+RSID1);
            gdres = gdm;
            GID = /*Int16.Parse(gdres);*/5;

        }
        // public int InsertRestaurant( int RSID, string TypeT, int Avl1, int Avl2, int Avl3, int No, string Orders, int T_Price, string TypeF)

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Comfirm_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true|| checkBox2.Checked == true|| checkBox3.Checked == true)
            {
                TypeT = "Breakfast";
            }
            if ((checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true)&& (checkBox4.Checked == true || checkBox5.Checked == true || checkBox6.Checked == true))
            {
                TypeT = "Breakfast & Launch";
            }
            if ((checkBox7.Checked == true || checkBox8.Checked == true || checkBox9.Checked == true) && (checkBox4.Checked == true || checkBox5.Checked == true || checkBox6.Checked == true))
            {
                TypeT = "Launch & Dinner";
            }
            if ((checkBox7.Checked == true || checkBox8.Checked == true || checkBox9.Checked == true) && (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true))
            {
                TypeT = "Breakfast & Dinner";
            }
            if ((checkBox7.Checked == true || checkBox8.Checked == true || checkBox9.Checked == true) && (checkBox4.Checked == true || checkBox5.Checked == true || checkBox6.Checked == true) && (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true))
            {
                TypeT = "Breakfast & Launch & Dinner";
            }

            if (checkBox1.Checked == true)
            {
                Order = Order + checkBox1.Text;
                T_price = T_price + 30;
                NO++;
            }
            if (checkBox2.Checked == true)
            {
                Order = Order + checkBox2.Text;
                T_price = T_price + 10;
                NO++;
            }
            if (checkBox3.Checked == true)
            {
                Order = Order + checkBox3.Text;
                T_price = T_price + 25;
                NO++;
            }
            if (checkBox4.Checked == true)
            {
                Order = Order + checkBox4.Text;
                T_price = T_price + 55;
                NO++;
            }
            if (checkBox5.Checked == true)
            {
                Order = Order + checkBox5.Text;
                T_price = T_price + 70;
                NO++;
            }
            if (checkBox6.Checked == true)
            {
                Order = Order + checkBox6.Text;
                T_price = T_price + 48;
                NO++;
            }
            if (checkBox7.Checked == true)
            {
                Order = Order + checkBox7.Text;
                T_price = T_price + 50;
                NO++;
            }
            if (checkBox8.Checked == true)
            {
                Order = Order + checkBox8.Text;
                T_price = T_price + 80;
                NO++;
            }
            if (checkBox9.Checked == true)
            {
                Order = Order + checkBox9.Text;
                T_price = T_price + 99;
                NO++;
            }
        

             Controller.InsertRestaurant( RSID,  TypeT, NO, Order, T_price,  TypeF);

            Controller.InsertRequesting_meal(RSID, GID, FID, date);
           Controller.InsertFinance(FID, descriptions, In_OR_Out, T_price);

           
                MessageBox.Show("Meal is booked successfully");
               Controller.InsertCurrentOrder(Order, T_price);
            
            
        }
        private void End_Click(object sender, EventArgs e)
        {
            Profile Profile = new Profile();
            Profile.Show();
            this.Hide();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Restaurant_Load(object sender, EventArgs e)
        {

        }
    }
}
