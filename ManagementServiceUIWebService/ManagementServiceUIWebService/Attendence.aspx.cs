using ManagementServiceUIWebService.ManagementServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManagementServiceUIWebService
{
    public partial class Attendence : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int AId = Convert.ToInt32(attendenceID.Text.Trim());
            int EId = Convert.ToInt32(txtEmployee.Text.Trim());
            DateTime date = Convert.ToDateTime(txtDate.Text.Trim());
            string reason = txtReason.Text.Trim();

            AttendenceBO attendenceBO = new AttendenceBO()
            {
                AttendenceID = AId,
                EmployeeID = EId,
                Date = date,
                Reason = reason
            };

            ManagementServiceSoapClient client = new ManagementServiceSoapClient();

            var result = client.AddAttendence(attendenceBO);

            if(result == 0)
            {
                lblAttendence.Text = "Not inserted successfully! Please try again!";
            }
            else
            {
                lblAttendence.Text = "Inserted successfully";
            }
        }
    }
}