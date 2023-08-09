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
    public class EmployeeDA
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ManagementConnectionString"].ConnectionString;

        public int insertEmployee(EmployeeBO employeeBO)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                SqlCommand cmd = new SqlCommand("CRUDEmployee", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", 1);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeBO.EmployeeID);
                cmd.Parameters.AddWithValue("@FirstName", employeeBO.FirstName);
                cmd.Parameters.AddWithValue("@LastName", employeeBO.LastName);
                cmd.Parameters.AddWithValue("@JobTitle", employeeBO.JoBTitle);
                cmd.Parameters.AddWithValue("@Department", employeeBO.Department);
                cmd.Parameters.AddWithValue("@Email", employeeBO.Email);

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

        public int updateEmployee(EmployeeBO employeeBO)
        {
            SqlConnection connection = new SqlConnection();

            try
            {
                SqlCommand cmd = new SqlCommand("CRUDEmployee", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", 2);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeBO.EmployeeID);
                cmd.Parameters.AddWithValue("@FirstName", employeeBO.FirstName);
                cmd.Parameters.AddWithValue("@LastName", employeeBO.LastName);
                cmd.Parameters.AddWithValue("@JobTitle", employeeBO.JoBTitle);
                cmd.Parameters.AddWithValue("@Department", employeeBO.Department);
                cmd.Parameters.AddWithValue("@Email", employeeBO.Email);

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

        public int deleteEmployee(EmployeeBO employeeBO)
        {
            SqlConnection connection = new SqlConnection();

            try
            {
                SqlCommand cmd = new SqlCommand("CRUDEmployee", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Action", 3);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeBO.EmployeeID);

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
