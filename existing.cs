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
    public partial class existing : Form
    {
        Controller controllerObj;

        public existing()
        {
            InitializeComponent();
            controllerObj = new Controller();

            this.FormClosing += Form1_FormClosing;
        }

        private void reservationNO_TextChanged(object sender, EventArgs e)
        {

        }

        private void booking1_Click(object sender, EventArgs e)
        {
           int reservation_number = Convert.ToInt32(reservationNO.Text);
            

            if (controllerObj.DeleteClientReservation(reservation_number) == 0)
            {
                MessageBox.Show("Reservation Number is Invalid or Doesn't Exists", "UnAvailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("Your Reservation has been cancelled... Thank You !!!");
            }

        }

        private void existing_Load(object sender, EventArgs e)
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

        private void Reserve_Click(object sender, EventArgs e)
        {
            string ClientUsername = textBox1.Text;

            DataTable dt = controllerObj.LoginAsClientValidationuser_only(ClientUsername);

            if (dt != null)
            {
                homeAfterLogin h = new homeAfterLogin(ClientUsername);
                h.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show(ClientUsername + " Is Not An Exisiting User");
            }
        }
    }
}
