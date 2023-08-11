using ManagementServiceUIWebService.ManagementServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManagementServiceUIWebService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int eID = Convert.ToInt32(employeeID.Text.Trim());
            string fName = txtFName.Text.Trim();
            string lName = txtLName.Text.Trim();
            string Job = txtJob.Text.Trim();
            string department = txtDepartment.Text.Trim();
            string email = txtEmail.Text.Trim();

            EmployeeBO newEmployee = new EmployeeBO()
            {
                EmployeeID = eID,
                FirstName = fName,
                LastName = lName,
                JoBTitle = Job,
                Department = department,
                Email = email,
            };

            ManagementServiceSoapClient client = new ManagementServiceSoapClient();

            var result = client.insertEmployee(newEmployee);

            if(result == 0)
            {
                lblEmployee.Text = "Employee not inserted";
            }
            else
            {
                lblEmployee.Text = "Employee inserted successfully";
            }
            clearAll();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int eID = Convert.ToInt32(employeeID.Text.Trim());
            string fName = txtFName.Text.Trim();
            string lName = txtLName.Text.Trim();
            string Job = txtJob.Text.Trim();
            string department = txtDepartment.Text.Trim();
            string email = txtEmail.Text.Trim();

            EmployeeBO updateEmployee = new EmployeeBO()
            {
                EmployeeID = eID,
                FirstName = fName,
                LastName = lName,
                JoBTitle = Job,
                Department = department,
                Email = email,
            };

            ManagementServiceSoapClient client = new ManagementServiceSoapClient();

            var result = client.updateEmployee(updateEmployee);

            if (result == 0)
            {
                lblEmployee.Text = "Employee not updated";
            }
            else
            {
                lblEmployee.Text = "Employee updated successfully";
            }
            clearAll();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int eID = Convert.ToInt32(employeeID.Text.Trim());

            EmployeeBO employeeBO = new EmployeeBO()
            {
                EmployeeID = eID,
            };

            ManagementServiceSoapClient client = new ManagementServiceSoapClient();

            var result = client.deleteEmployee(employeeBO);

            if (result == 0)
            {
                lblEmployee.Text = "Employee not deleted";
            }
            else
            {
                lblEmployee.Text = "Employee deleted successfully";
            }
            clearAll();
        }

        public void clearAll()
        {
            employeeID.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtJob.Text = "";
            txtDepartment.Text = "";
            txtEmail.Text = "";
        }
    }
}