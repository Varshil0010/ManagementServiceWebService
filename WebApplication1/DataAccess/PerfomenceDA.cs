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
    public class PerfomenceDA
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ManagementConnectionString"].ConnectionString;

        public int InsertPerformence(PerfomanceBO perfomanceBO)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd = new SqlCommand("CRUDPerformance", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", 1);
                cmd.Parameters.AddWithValue("@PerfomanceID", perfomanceBO.PerfomanceID);
                cmd.Parameters.AddWithValue("@EmployeeID", perfomanceBO.EmployeeID);
                cmd.Parameters.AddWithValue("@ReviewDate", perfomanceBO.ReviewDate);
                cmd.Parameters.AddWithValue("@Goal", perfomanceBO.Goal);
                cmd.Parameters.AddWithValue("@Review", perfomanceBO.Review);

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
