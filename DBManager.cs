using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Airline
{
    public class DBManager
    {

        static string DB_Connection_String = @"Data Source=DESKTOP-R71GI7B\SQLEXPRESS;Initial Catalog=AIRLINE;Integrated Security=True";
        SqlConnection myConnection;

        public DBManager()
        {
            myConnection = new SqlConnection(DB_Connection_String);
            try
            {
                myConnection.Open();
                Console.WriteLine("The DB connection is opened successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("The DB connection is failed");
                Console.WriteLine(e.ToString());
            }
        }

        public int ExecuteNonQuery(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                return myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public DataTable ExecuteReader(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                SqlDataReader reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                else
                {
                    if (!reader.IsClosed)
                        reader.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public object ExecuteScalar(string query)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                return myCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public void CloseConnection()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        //Stored Procedures

        public int DecrementAvailableSeats(int FlightNo, int p)
        {
            SqlCommand cmd = new SqlCommand("DecrementAvailableSeats", myConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@FlightNumber", FlightNo));
            cmd.Parameters.Add(new SqlParameter("@Seats", p));

           return cmd.ExecuteNonQuery();
        }

        public DataTable ReviewAssignedPilotsAndCrew (string user)
        {
            SqlCommand cmd = new SqlCommand("ReviewAssignedPilotsAndCrew", myConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Username", user));

            SqlDataReader d = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(d);

            return dt;
        }

        public DataTable ForgetPassword(string email)
        {
            SqlCommand cmd = new SqlCommand("ForgetPassword", myConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Email", email));

            SqlDataReader d = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(d);

            return dt;
        }

        public DataTable GetUsernameFromReservation(int rno)
        {
            SqlCommand cmd = new SqlCommand("GetUsernameFromReservation", myConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@RNO", rno));

            SqlDataReader d = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(d);

            return dt;
        }

        public int InsertingServiceRequested(string user, int sno, int rno)
        {
            SqlCommand cmd = new SqlCommand("InsertingServiceRequested", myConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@User", user));
            cmd.Parameters.Add(new SqlParameter("@SNO", sno));
            cmd.Parameters.Add(new SqlParameter("@RNO", rno));

            return cmd.ExecuteNonQuery();
        }
    }
}
;