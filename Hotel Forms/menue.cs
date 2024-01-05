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
    public partial class menue : Form
    {
        static string gdm;

        private Form activeForm;

        private Random random;
        public menue()
        {
        }
            public menue(string gd)
        {
            InitializeComponent();
            //menue.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            random = new Random();
            this.Text = string.Empty;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            gdm = gd;
        }
        private void Inhertform(Form Opthionform, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = Opthionform;
              Opthionform.TopLevel = false;
          //  Opthionform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                      activeForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            Opthionform.Dock = DockStyle.Fill;
          panel3.Controls.Add(Opthionform);
           this.panel3.Tag = Opthionform;
            Opthionform.Show();

            Opthionform.BringToFront();

            label1.Text = Opthionform.Text;

            


        }
        private void Hideform(Form Opthionform, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = Opthionform;
            Opthionform.Close();



        }


        private void button1_Click(object sender, EventArgs e)
        {
            Hideform(new GYM(), sender);
            Hideform(new Restaurant(), sender);
            Hideform(new Profile(), sender);
            Hideform(new Room(), sender);

            this.Show();
            label1.Text = "Home";
        }

        private void menue_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Show();
        }

        private void Gym_Click(object sender, EventArgs e)
        {
            Inhertform(new GYM(gdm), sender);


        }

        private void Room_Click(object sender, EventArgs e)
        {
            Inhertform(new Room(gdm), sender);

        }

        private void Restaurant_Click(object sender, EventArgs e)
        {
            Inhertform(new Restaurant(gdm), sender);

        }

        private void Profile_Click(object sender, EventArgs e)
        {
            Inhertform(new Profile(), sender);

        }

        private void End_Click(object sender, EventArgs e)
        {
            Hideform(new menue(gdm), sender);
          
            Form m = new W1();
            m.Show();
            this.Close();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
