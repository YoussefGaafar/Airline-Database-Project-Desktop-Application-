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
    public partial class Form1 : Form
    {
        Controller controllerObj;
        string username;
        public Form1( string u)
        {
            InitializeComponent();
            username = u;
            this.FormClosing += Form1_FormClosing;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();

        }
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            //In case windows is trying to shut down, don't hold the process up
            if (e.CloseReason == CloseReason.UserClosing)
            {



                Application.Exit();


            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int result = controllerObj.changepassword(username,textBox1.Text);
            if (result == 1)
            {
                MessageBox.Show("Password is successfully changed");
                homeAfterLogin h = new homeAfterLogin(username);
                h.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Password is not changed");



        }
    }
}
