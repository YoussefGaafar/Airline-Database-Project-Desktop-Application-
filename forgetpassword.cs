using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Airline
{
    public partial class forgetpassword : Form
    {
        public static string to;
        Controller cont;
        public forgetpassword()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;

        }

        private void userforget_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void send_Click(object sender, EventArgs e)
        {
            string from, pass, message1;
            DataTable userPass=new DataTable();
            MailMessage message = new MailMessage();
            from= "abdallacompany99@gmail.com";
            to = userforget.Text;
            DBManager dbm = new DBManager();
            userPass = dbm.ForgetPassword(to);

            pass = "A12345aaa";
            message1 = "hi, your password is "+ userPass.Rows[0][0].ToString();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = message1;
            message.Subject = "Abdalla's Airline password request";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from,pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Password successfully sent");
            }catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }

            Loginform L = new Loginform();
            L.Show();
            this.Hide();

        }

        private void forgetpassword_Load(object sender, EventArgs e)
        {
            cont = new Controller();
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
