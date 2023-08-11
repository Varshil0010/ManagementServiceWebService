using BusinessObject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AttendenceDA
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ManagementConnectionString"].ConnectionString;

        public int AddAttendence(AttendenceBO attendenceBO)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd = new SqlCommand("CRUDAttendence", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", 1);
                cmd.Parameters.AddWithValue("@AttendenceID", attendenceBO.AttendenceID);
                cmd.Parameters.AddWithValue("@EmployeeID", attendenceBO.EmployeeID);
                cmd.Parameters.AddWithValue("@Date", attendenceBO.Date);
                cmd.Parameters.AddWithValue("@Reason", attendenceBO.Reason);

                connection.Open();
                int result = cmd.ExecuteNonQuery();

                return result;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message, ex);
            }
            finally 
            { 
                connection.Close(); 
            }
        }

        public int UpdateAddendence(AttendenceBO attendenceBO)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd = new SqlCommand("CRUDAttendence", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", 2);
                cmd.Parameters.AddWithValue("@AttendenceID", attendenceBO.AttendenceID);
                cmd.Parameters.AddWithValue("@EmployeeID", attendenceBO.EmployeeID);
                cmd.Parameters.AddWithValue("@Date", attendenceBO.Date);
                cmd.Parameters.AddWithValue("@Reason", attendenceBO.Reason);

                connection.Open();
                int result = cmd.ExecuteNonQuery();

                return result;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw new Exception(message, ex);
            }
            finally 
            { 
                connection.Close(); 
            }
        }
    }
}
