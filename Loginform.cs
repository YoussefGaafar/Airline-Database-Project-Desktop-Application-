using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class Loginform : Form
    {
        Controller controllerObj;

        public Loginform()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            password.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

            DataTable ClientUsername = controllerObj.LoginAsClientValidation(guna2TextBox1.Text,password.Text);

            DataTable ResultCrewOrPilot = controllerObj.LoginAsPilotOrCrew(guna2TextBox1.Text,password.Text);

            DataTable ResultOfficeEmployee = controllerObj.LoginAsOfficeEmployee(guna2TextBox1.Text,password.Text);

            DataTable ResultAdmin = controllerObj.LoginAsAdministrator(guna2TextBox1.Text, password.Text);

            if (ClientUsername != null)
            {
                string x = guna2TextBox1.Text;
                homeAfterLogin h = new homeAfterLogin(x);
                h.Show();
                this.Hide();
            }

            else if (ResultCrewOrPilot != null)
            {
                AssignedFlightsForPilotsAndCrew A = new AssignedFlightsForPilotsAndCrew(guna2TextBox1.Text);
                A.Show();
                this.Hide();
            }

            else if (ResultOfficeEmployee != null)
            {
                EmployeeForm F = new EmployeeForm();
                F.Show();
                this.Hide();
            }
            else if (ResultAdmin != null)
            {
                Adminstratorform A = new Adminstratorform();
                A.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sorry, the Username or Password you entered is incorrect. Please check and try again.", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            JoinNowForm j = new JoinNowForm();
            j.Show();
            this.Hide();
        }

        private void Loginform_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgetpassword f = new forgetpassword();
            f.Show();
            this.Hide();

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
