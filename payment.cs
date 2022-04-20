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
    public partial class payment : Form
    {
        int ReservationNumber = 0;
        Controller controllerObj = new Controller();

        public payment(int x , int no,int p,string user)
        {
            InitializeComponent();
            int value = x;
            
            DataTable dt = controllerObj.GetReservationNumberOfClient(user, no);
            ReservationNumber = int.Parse(dt.Rows[0][0].ToString());
           
            label1.Text = "You have successfuly paid" + " $" + value.ToString()+" Your reservation number is "+ ReservationNumber.ToString();
            DBManager db = new DBManager();

            int R =  db.DecrementAvailableSeats(no,p);
            this.FormClosing += Form1_FormClosing;
        }

        private void payment_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void payment_Load(object sender, EventArgs e)
        {
            

            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
