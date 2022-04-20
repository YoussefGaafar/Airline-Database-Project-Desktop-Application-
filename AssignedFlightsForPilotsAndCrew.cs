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
    public partial class AssignedFlightsForPilotsAndCrew : Form
    {
        string Username;
        public AssignedFlightsForPilotsAndCrew(string u)
        {
            InitializeComponent();
            Username = u;
            DBManager db = new DBManager();

            DataTable dt = db.ReviewAssignedPilotsAndCrew(Username);

            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Refresh();
            this.FormClosing += Form1_FormClosing;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AssignedFlightsForPilotsOrCrew_Load(object sender, EventArgs e)
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
    }
}
