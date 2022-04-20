using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;

namespace Airline
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }

        public DataTable FromList()
        {
            string query = "SELECT (CODE + ', ' + CITY + ', '+ COUNTRY) AS NAME FROM AIRPORT;";

            return dbMan.ExecuteReader(query);
        }
        public int removeclient(string username)
        {
            string query = "DELETE FROM CLIENT WHERE USERNAME = '" + username + "';";
            // MessageBox.Show(query);
            return dbMan.ExecuteNonQuery(query);
        }
        public int removeemployee(string username)
        {
            string query = "DELETE FROM employees WHERE USERNAME = '" + username + "';";
            // MessageBox.Show(query);
            return dbMan.ExecuteNonQuery(query);
        }
        public int removeairport(string code)
        {
            string query = "DELETE FROM airport WHERE code = '" + code + "';";
            // MessageBox.Show(query);
            return dbMan.ExecuteNonQuery(query);
        }
        public int removeflight(int flightno)
        {
            string query = "DELETE FROM flight WHERE flight_number = " + flightno + ";";
             //MessageBox.Show(query);
            return dbMan.ExecuteNonQuery(query);
        }
        public int removeservice(int serviceno)
        {
            string query = "DELETE FROM services WHERE service_no = " + serviceno + ";";
           // MessageBox.Show(query);
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable ToList(string combobox)
        {
            string query = "SELECT (CODE + ',' + CITY + ','+ COUNTRY) AS NAME FROM AIRPORT WHERE CODE != (SELECT SUBSTRING ('" + combobox + "',1,3));";


            return dbMan.ExecuteReader(query);
        }

        public DataTable SearchButtonGrid(string from, string to, string date, int fare)
        {
            string query = "SELECT SOURCE,DESTINATION,FLIGHT_DATE," + fare.ToString() + "*FARE AS Fare FROM FLIGHT WHERE SOURCE IN (SELECT SUBSTRING ('" +
               from + "',1,3))" + " AND DESTINATION IN (SELECT SUBSTRING('" + to + "',1,3))" + "AND FLIGHT_DATE = '" + date + "' AND AVAILABLE_SEATS - " + fare + " >= 0 ;";

            return dbMan.ExecuteReader(query);

        }
        public int Addemployee(string username, int password, string fname, string lname, string jobtitle, int id,string dateofbirth)
        {
           

                string query = "INSERT INTO employees (username, password, fname, lname,jobtitle,id,DATE_OF_BIRTH) " +
                "Values ('" + username + "'," + password + ",'" + fname + "','" + lname + "','"+jobtitle+"',"+id+",'" +dateofbirth+"');";
               // MessageBox.Show(query);

                return dbMan.ExecuteNonQuery(query);
           

        }
        public DataTable flightgetter(string name)
        {
            string query = "SELECT RESERVATION_NUMBER FROM BOOKING WHERE CLIENT_USERNAME ='" + name + "';";


            return dbMan.ExecuteReader(query);

        }
        public DataTable Deletebooking(string name)
        {

            string query = "DELETE FROM BOOKING WHERE CLIENT_USERNAME = '" + name + "'; Delete from SERVICE_REQUESTED WHERE CLIENT_USERNAME='" + name + "';";


            return dbMan.ExecuteReader(query);

        }
        public int changepassword (string username, string newpass) {
            string query = "update client set password='" + newpass + "' where username ='" + username + "';";
            return dbMan.ExecuteNonQuery(query);
        
        }
        public int addflight(int flightno, string flightdate, int availableseats, DateTime arrivaltime, DateTime departuretime, float fare, string source, string destination)
        {


            string query = "INSERT INTO flight (FLIGHT_NUMBER, FLIGHT_DATE, AVAILABLE_SEATS, ARRIVAL_TIME,DEPARTURE_TIME,FARE,SOURCE,DESTINATION) " +
            "Values (" + flightno + ",'" + flightdate + "'," + availableseats + ",'" + arrivaltime + "','" + departuretime + "'," + fare + ",'" + source + "', '"+destination+"');";
           // MessageBox.Show(query);

            return dbMan.ExecuteNonQuery(query);


        }
        public int addservice(int serviceno, string servicename, int serviceprice)
        {


            string query = "INSERT INTO services (SERVICE_NO, SERVICE_NAME, SERVICE_PRICE) " +
            "Values (" + serviceno + ",'" + servicename + "'," + serviceprice + ");";
            //MessageBox.Show(query);

            return dbMan.ExecuteNonQuery(query);


        }
        public int addairplane(string airplaneno, int noofseats, string model)
        {


            string query = "INSERT INTO airplanes (AIRPLANE_NO, NO_OF_SEATS, MODEL) " +
            "Values ('" + airplaneno + "'," + noofseats + ",'" + model + "');";
            //MessageBox.Show(query);

            return dbMan.ExecuteNonQuery(query);


        }
        public int addairport(string code, string country, string city)
        {


            string query = "INSERT INTO airport (code, country, city) " +
            "Values ('" + code + "','" + country + "','" + city + "');";
            //MessageBox.Show(query);

            return dbMan.ExecuteNonQuery(query);


        }
        public int assignairplane(int flightno, string airplaneno)
        {


            string query = "INSERT INTO assign_airplanes (FLIGHT_NO, AIRPLANE_NO) " +
            "Values (" + flightno + ",'" + airplaneno + "');";
           // MessageBox.Show(query);

            return dbMan.ExecuteNonQuery(query);


        }
        public int assignpilot(int flightno, string username)
        {


            string query = "INSERT INTO assign_pilots (FLIGHT_NO, username) " +
            "Values (" + flightno + ",'" + username + "');";
            //MessageBox.Show(query);

            return dbMan.ExecuteNonQuery(query);


        }
        public int assigncrew(int flightno, string username)
        {


            string query = "INSERT INTO assign_crew (FLIGHT_NO, username) " +
            "Values (" + flightno + ",'" + username + "');";
           // MessageBox.Show(query);

            return dbMan.ExecuteNonQuery(query);


        }

        public DataTable ServiceSelection()
        {
            string query = "SELECT * FROM SERVICES";

            return dbMan.ExecuteReader(query);
        }
        public int AddClient(string user, string pass, string fn, string ln, int ssn, string email, int phone)
        {
            string query = "INSERT INTO CLIENT(USERNAME,PASSWORD,FNAME,LNAME,PHONE_NUMBER,EMAIL,SSN) VALUES('" + user + "','" + pass + "'," + "'" + fn + "','" + ln + "'," + phone + ",'" + email + "'," + ssn + ");";

            return dbMan.ExecuteNonQuery(query);
        }

        //Login Validations

        public DataTable LoginAsClientValidation(string user , string pass)
        {
            string query = "SELECT USERNAME FROM CLIENT WHERE USERNAME = '" + user + "' and PASSWORD ='" + pass + "';";

            return dbMan.ExecuteReader(query);
        }
        public DataTable LoginAsClientValidationuser_only(string user)
        {
            string query = "SELECT USERNAME FROM CLIENT WHERE USERNAME = '" + user + "';";

            return dbMan.ExecuteReader(query);
        }

        public DataTable LoginAsPilotOrCrew(string user,string pass)
        {
            string query = "SELECT USERNAME FROM Employees WHERE USERNAME = '" + user + "' AND (JobTitle = 'Pilot' OR JobTitle = 'Stewart') and PASSWORD ='" + pass + "';";

            return dbMan.ExecuteReader(query);
        }

        public DataTable LoginAsOfficeEmployee(string user, string pass)
        {
            string query = "SELECT USERNAME FROM Employees WHERE USERNAME = '" + user + "' AND JobTitle = 'OfficeEmployee'and PASSWORD ='" + pass + "';";

            return dbMan.ExecuteReader(query);
        }

        public DataTable LoginAsAdministrator(string user, string pass)
        {
            string query = "SELECT USERNAME FROM Employees WHERE USERNAME = '" + user + "' AND JobTitle = 'Administrator' and PASSWORD ='"+pass+"';";

            return dbMan.ExecuteReader(query);
        }

        ////////////////////

        public int InsertBooking(string user, int flight)
        {
            Random rd = new Random();

            int rand_num = rd.Next(1, 500000);

            string query = "INSERT INTO BOOKING (CLIENT_USERNAME, FLIGHT_NUMBER, RESERVATION_NUMBER) VALUES('" + user + "'," + flight + "," + rand_num + ");";

            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GettingFlightNumberForReservation(string from, string to, string date, int fare, int p)
        {
            int f = fare / p;
            string query = "SELECT FLIGHT_NUMBER FROM FLIGHT WHERE FLIGHT_DATE = '" + date + "' AND SOURCE IN (SELECT SUBSTRING ('" +
            from + "',1,3))" + " AND DESTINATION IN (SELECT SUBSTRING('" + to + "',1,3))" + " AND FARE = " + f + ";";

            return dbMan.ExecuteReader(query);
        }

        public DataTable FareOfAFlight(int Fno)
        {
            string query = "SELECT FARE FROM FLIGHT WHERE FLIGHT_NUMBER = " + Fno + ";";

            return dbMan.ExecuteReader(query);
        }

        public int InsertingServicesRequest(string user, int no, int Rno)
        {
            string query = "INSERT INTO SERVICE_REQUESTED (SERVICE_NO,CLIENT_USERNAME,RESERVATION_NUMBER) VALUES (" + no + ",'" + user + "'," + Rno + ");";

            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteServiceRequest(string user, int no)
        {
            string query = "DELETE FROM SERVICE_REQUESTED WHERE CLIENT_USERNAME = '" + user + "' AND SERVICE_NO = " + no + ";";

            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetReservationNumberOfClient(string user, int fno)
        {
            string query = "SELECT RESERVATION_NUMBER FROM BOOKING WHERE FLIGHT_NUMBER =" + fno + " AND CLIENT_USERNAME = '" + user + "';";

            return dbMan.ExecuteReader(query);
        }

        public int DeleteClientReservation(int Rno)
        {
            //DELETE FROM BOOKING WHERE RESERVATION_NUMBER = 386743; DELETE FROM SERVICE_REQUESTED WHERE RESERVATION_NUMBER = 386743;
            string query = "DELETE FROM BOOKING WHERE RESERVATION_NUMBER = " + Rno + "; DELETE FROM SERVICE_REQUESTED WHERE RESERVATION_NUMBER = " + Rno + ";";

            return dbMan.ExecuteNonQuery(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

    }


}
