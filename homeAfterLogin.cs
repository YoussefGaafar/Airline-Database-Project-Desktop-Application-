
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class homeAfterLogin : Form
    {
        Controller controllerObj;
        string ClientUsername;
        int NoOfPassengers = 0;

        public homeAfterLogin()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.FromList();
            guna2ComboBox1.DataSource = dt;
            guna2ComboBox1.DisplayMember = "NAME";
            guna2DateTimePicker1.Value = DateTime.Now;

            this.FormClosing += Form1_FormClosing;
        }

        public homeAfterLogin(string name)
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.FromList();
            guna2ComboBox1.DataSource = dt;
            guna2ComboBox1.DisplayMember = "NAME";
            welcomeLabel.Text = "Welcome" + " " + name;
            ClientUsername = name;
            NoOfPassengers = (int)guna2NumericUpDown1.Value;

            guna2DateTimePicker1.Value = DateTime.Now;
            this.FormClosing += Form1_FormClosing;
        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void homeAfterLogin_Load(object sender, EventArgs e)
        {
            //NoOfPassengers = Convert.ToInt32(guna2NumericUpDown1.Value);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
           SearchButtonResults S = new SearchButtonResults(guna2ComboBox1.Text, guna2ComboBox4.Text, guna2DateTimePicker1.Value.ToString("yyyy-MM-dd"), Convert.ToInt32(guna2NumericUpDown1.Value),ClientUsername,NoOfPassengers);

           S.Show();

            this.Hide();
        }

        

        

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1 = controllerObj.ToList(guna2ComboBox1.Text);
            guna2ComboBox4.DataSource = dt1;
            guna2ComboBox4.DisplayMember = "NAME";
            guna2ComboBox4.Refresh();
        }

        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            //In case windows is trying to shut down, don't hold the process up
            if (e.CloseReason == CloseReason.UserClosing)
            {

               
                    Application.Exit();
               

            }
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (guna2DateTimePicker1.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Cannot search for flights before today's date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                guna2DateTimePicker1.Value = DateTime.Now;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            managebooking x = new managebooking(ClientUsername);
            x.Show();
            this.Hide();
        }

        private void changepassword_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1(ClientUsername);
            f.Show();
            this.Hide();

        }
    }
}

