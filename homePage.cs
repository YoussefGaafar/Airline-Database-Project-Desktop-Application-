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
    public partial class homePage : Form
    {
        Controller controllerObj;
        public homePage()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.FromList();
            guna2ComboBox1.DataSource = dt;
            guna2ComboBox1.DisplayMember = "NAME";
            guna2DateTimePicker1.Value = DateTime.Now;
            this.FormClosing += Form1_FormClosing;
        }
       
        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void homePage_Load(object sender, EventArgs e)
        {
          
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchButtonResults S = new SearchButtonResults(guna2ComboBox1.Text, guna2ComboBox4.Text, guna2DateTimePicker1.Value.ToString("yyyy-MM-dd"), Convert.ToInt32(guna2NumericUpDown1.Value));
           
            S.Show();
            this.Hide();
        }

        private void JoinNowButton_Click(object sender, EventArgs e)
        {
            JoinNowForm j;
            j = new JoinNowForm();
            j.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Loginform x = new Loginform();
            x.Show();
            this.Hide();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1 = controllerObj.ToList(guna2ComboBox1.Text);
            guna2ComboBox4.DataSource = dt1;
            guna2ComboBox4.DisplayMember = "NAME";
            guna2ComboBox4.Refresh();
        }

        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (guna2DateTimePicker1.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Cannot search for flights before today's date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                guna2DateTimePicker1.Value = DateTime.Now;
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
