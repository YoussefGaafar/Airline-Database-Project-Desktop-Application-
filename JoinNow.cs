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
    public partial class JoinNowForm : Form
    {
        Controller controllerObj;

        public JoinNowForm()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            password.PasswordChar = '*';
        }

        private void JoinNowForm_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            this.FormClosing += Form1_FormClosing;
        }

        private void go_Click(object sender, EventArgs e)
        {
            bool check = false;

            foreach (Control c in this.Controls)

            {
                if (c is Guna.UI2.WinForms.Guna2TextBox)

                {

                    if (((Guna.UI2.WinForms.Guna2TextBox)c).Text == string.Empty)

                    {
                        MessageBox.Show("Please Fill all of the Fields and Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        check = true;

                        break;
                    }

                }

            }

            if(check == false)
            {
                int Result = controllerObj.AddClient(username.Text, password.Text, firstname.Text, lastname.Text, Int32.Parse(ssn.Text), email.Text, Int32.Parse(phonenumber.Text));

                if (Result == 0)
                {
                    MessageBox.Show("Please Fill all of the Fields and Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("Welcome Mr/Mrs " + firstname.Text + " " + lastname.Text + " Click OK to Proceed", " ", MessageBoxButtons.OK);

                    homeAfterLogin H = new homeAfterLogin(username.Text);

                    H.Show();

                    this.Hide();
                }
            }
           
        }

        private void username_TextChanged(object sender, EventArgs e)
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
