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
    public partial class ServiceSelectionForBooking : Form
    {
        int f = 0;
        int ServicesFees = 0;
        int FlightNo = 0;
        string ClientUsername;
        int passengers;
        int ReservationNumber;

        Controller controllerObj;

        public ServiceSelectionForBooking()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;

        }
        public ServiceSelectionForBooking(int Fare,string user, int FlightNumber, int p, int Rno)
        {
            InitializeComponent();
            f = Fare;
            ClientUsername = user;
            FlightNo = FlightNumber;
            passengers = p;
            ReservationNumber = Rno;
            this.FormClosing += Form1_FormClosing;
        }

        private void ServiceSelectionForBooking_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.ServiceSelection();
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.Columns.Add(chk);
            chk.HeaderText = "Check Data";
            chk.Name = "chk";

            guna2DataGridView1.Columns[0].ReadOnly = true;
            guna2DataGridView1.Columns[1].ReadOnly = true;
            guna2DataGridView1.Columns[2].ReadOnly = true;
            guna2DataGridView1.Columns[3].ReadOnly = false;
            guna2DataGridView1.AllowUserToAddRows = false;
            guna2DataGridView1.Refresh();
        }



        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            int ClientFees = f + ServicesFees;
            payment p = new payment(ClientFees,FlightNo,passengers,ClientUsername);
            p.Show();
            this.Hide();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DBManager dbm = new DBManager();

            DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (chk.Selected == true)
            {
                if (chk.Value == chk.TrueValue)
                {
                    ServicesFees += Int32.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());

                    int ServiceNo = Int32.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                    //controllerObj.InsertingServicesRequest(ClientUsername, ServiceNo,ReservationNumber);
                    dbm.InsertingServiceRequested(ClientUsername, ServiceNo, ReservationNumber);
                }
                else
                {
                    ServicesFees -= Int32.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    int ServiceNo = Int32.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                    controllerObj.DeleteServiceRequest(ClientUsername, ServiceNo);
                }
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
