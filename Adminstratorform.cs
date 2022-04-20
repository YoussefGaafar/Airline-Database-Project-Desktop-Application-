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
    public partial class Adminstratorform : Form
    {
        Controller controllerObj;
        public Adminstratorform()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            int result=controllerObj.removeclient(cusername.Text);
            if (result == 1)
            
                MessageBox.Show("Client is removed successfuly");
            else
                MessageBox.Show("Username is not found");

        }

        private void cusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            JoinNowForm j;
            j = new JoinNowForm();
            j.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Result = controllerObj.Addemployee(username.Text, Int32.Parse(pass.Text), fname.Text, lname.Text, jobtitle.Text, Int32.Parse(id.Text), dateofbirth.Text); 

            if (Result == 0 || username.Text == string.Empty|| pass.Text == string.Empty || fname.Text == string.Empty || lname.Text == string.Empty || jobtitle.Text == string.Empty || id.Text == string.Empty || dateofbirth.Text == string.Empty)
            
                MessageBox.Show("Invalid Insertion... Try Again");
           
            else
            
                MessageBox.Show("New Employee Has been Added ");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            int result = controllerObj.removeemployee(usernametoberemoved.Text);
            if (result == 1)

                MessageBox.Show("employee is removed successfuly");
            else
                MessageBox.Show("Username is not found");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int Result = controllerObj.addflight(Int32.Parse(flightno.Text), flightdate.Text, Int32.Parse(availableseats.Text), Convert.ToDateTime(arrivaltime.Text.ToString()), Convert.ToDateTime(departuretime.Text.ToString()), Int32.Parse(fare.Text), source.Text,destination.Text);

            if (Result == 0 || flightno.Text == string.Empty || flightdate.Text == string.Empty || availableseats.Text == string.Empty || arrivaltime.Text == string.Empty || departuretime.Text == string.Empty || fare.Text == string.Empty || source.Text == string.Empty || destination.Text == string.Empty)

                MessageBox.Show("Invalid Insertion... Try Again");

            else

                MessageBox.Show("New flight Has been Added ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            int result = controllerObj.removeflight(Int16.Parse(flightnotoberemoved.Text));
            if (result == 1)

                MessageBox.Show("flight is removed successfuly");
            else
                MessageBox.Show("flight is not found");
        }
        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            //In case windows is trying to shut down, don't hold the process up
            if (e.CloseReason == CloseReason.UserClosing)
            {

                
                    Application.Exit();
              

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int Result = controllerObj.addservice(Int32.Parse(serviceno.Text), servicename.Text, Int32.Parse(serviceprice.Text));

            if (Result == 0 || serviceno.Text == string.Empty || servicename.Text == string.Empty || serviceprice.Text == string.Empty)

                MessageBox.Show("Invalid Insertion... Try Again");

            else

                MessageBox.Show("New service Has been Added ");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            int result = controllerObj.removeservice(Int16.Parse(servicenotoberemoved.Text));
            if (result == 1)

                MessageBox.Show("service is removed successfuly");
            else
                MessageBox.Show("service is not found");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int Result = controllerObj.addairplane(airplaneno.Text, Int32.Parse(noofseats.Text), model.Text);

            if (Result == 0 || airplaneno.Text == string.Empty || noofseats.Text == string.Empty || model.Text == string.Empty)

                MessageBox.Show("Invalid Insertion... Try Again");

            else

                MessageBox.Show("New airplane Has been Added ");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int Result = controllerObj.assignairplane(Int32.Parse(flight_no.Text), airplane_no.Text);

            if (Result == 0 || flight_no.Text == string.Empty ||airplane_no.Text == string.Empty)

                MessageBox.Show("Invalid Assigning... Try Again");

            else

                MessageBox.Show("New airplane Has been Assigned ");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int Result = controllerObj.assignpilot(Int16.Parse(flightnoAP.Text), usernamepilot.Text);

            if (Result == 0 || flightnoAP.Text == string.Empty || usernamepilot.Text == string.Empty)

                MessageBox.Show("Invalid Assigning... Try Again");

            else

                MessageBox.Show("New pilot Has been Assigned ");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int Result = controllerObj.assigncrew(Int16.Parse(flightnoAC.Text), usernamecrew.Text);

            if (Result == 0 || flightnoAC.Text == string.Empty || usernamecrew.Text == string.Empty)

                MessageBox.Show("Invalid Assigning... Try Again");

            else

                MessageBox.Show("New person Has been Assigned ");
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            int Result = controllerObj.addairport(code.Text, country.Text, city.Text);

            if (Result == 0 || code.Text == string.Empty || country.Text == string.Empty || city.Text == string.Empty)

                MessageBox.Show("Invalid Insertion... Try Again");

            else

                MessageBox.Show("New airport Has been Added ");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            int result = controllerObj.removeairport(code1.Text);
            if (result == 1)

                MessageBox.Show("airport is removed successfuly");
            else
                MessageBox.Show("code is not found");
        }
    }
    }


