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
    public partial class managebooking : Form
    {
        string ClientUsername;

        Controller controllerObj;
        public managebooking(string k)
        {
            InitializeComponent();
            ClientUsername = k;
            this.FormClosing += Form1_FormClosing;


        }

        private void managebooking_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable f = controllerObj.flightgetter(ClientUsername);

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Name = "Delete";
            btn.Text = "Delete";
            btn.UseColumnTextForButtonValue = true;
            guna2DataGridView1.DataSource = f;
            guna2DataGridView1.Columns.Add(btn);

            guna2DataGridView1.Refresh();
        }
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            //In case windows is trying to shut down, don't hold the process up
            if (e.CloseReason == CloseReason.UserClosing)
            {


                Application.Exit();


            }
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            controllerObj.Deletebooking(ClientUsername);
            int rowIndex = guna2DataGridView1.CurrentCell.RowIndex;
            guna2DataGridView1.Rows.RemoveAt(rowIndex);
            guna2DataGridView1.Refresh();


        }
    }
}
