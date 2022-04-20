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
    public partial class SearchButtonResults : Form
    {
        string f1;
        string t1;
        string d1;
        int f2;//No.of.passengers
        
        string ClientUsername;
        Controller controllerObj;
        public SearchButtonResults(string from, string to, string date, int fare, string user,int p)
        {
            InitializeComponent();
            f1 = from;
            t1 = to;
            d1 = date;
            f2 = fare;
            ClientUsername = user;
            this.FormClosing += Form1_FormClosing;
        }

        public SearchButtonResults(string from, string to , string date, int fare)
        {
            InitializeComponent();
            f1 = from;
            t1 = to;
            d1 = date;
            f2 = fare;
            this.FormClosing += Form1_FormClosing;
        }

        private void SearchButtonResults_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.SearchButtonGrid(f1, t1, d1, f2);

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Name = "Select";
            btn.Text = "Select";
            btn.UseColumnTextForButtonValue = true;
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.Columns.Add(btn);

            guna2DataGridView1.AllowUserToAddRows = false;

            guna2DataGridView1.Refresh();

            
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Fare = Int32.Parse(this.guna2DataGridView1[3, e.RowIndex].Value.ToString());

            if (ClientUsername == null)
            {
                MessageBox.Show("Please Login/Register to Proceed");
                Loginform L = new Loginform();
                L.Show();
                this.Hide();

            }

            else
            { 
                DataTable dt = controllerObj.GettingFlightNumberForReservation(f1, t1, d1,Fare,f2);

                int FlightNumber = int.Parse(dt.Rows[0][0].ToString());

                controllerObj.InsertBooking(ClientUsername, FlightNumber);

                DataTable R = controllerObj.GetReservationNumberOfClient(ClientUsername, FlightNumber);

                int ReservationNumber = Int32.Parse(R.Rows[0][0].ToString());

                ServiceSelectionForBooking S = new ServiceSelectionForBooking(Fare, ClientUsername, FlightNumber,f2,ReservationNumber);

                S.Show();
                this.Hide();
            }
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            //In case windows is trying to shut down, don't hold the process up
            if (e.CloseReason == CloseReason.UserClosing)
            {

               
                    Application.Exit();
                

            }
        }
    }
}
