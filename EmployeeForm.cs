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
    public partial class EmployeeForm : Form
    {
        Controller controllerObj;

        public EmployeeForm()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;

        }
        public EmployeeForm(string name)
        {
            //guna2TextBox1.Text="Welcome employee" + " " + name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            JoinNowForm f = new JoinNowForm();
            f.Show();
            this.Hide();
        }

        private void booking1_Click(object sender, EventArgs e)
        {
            existing ex = new existing();
            ex.Show();
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
