using ManagementServiceUIWebService.ManagementServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManagementServiceUIWebService
{
    public partial class Performance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int PID = Convert.ToInt32(performanceID.Text.Trim());
            int EID = Convert.ToInt32(txtEmployee.Text.Trim());
            DateTime date = Convert.ToDateTime(txtDate.Text.Trim());
            string goal = txtGoal.Text.Trim();
            string review = txtReview.Text.Trim();

            PerfomanceBO performanceBO = new PerfomanceBO()
            {
                PerfomanceID = PID,
                EmployeeID = EID,
                ReviewDate = date,
                Goal = goal,
                Review = review
            };

            ManagementServiceSoapClient client = new ManagementServiceSoapClient();

            var result = client.AddPerformence(performanceBO);

            if(result == 0)
            {
                lblPerformance.Text = "Not inserted! Please try again";
            }
            else
            {
                lblPerformance.Text = "Inserted successfully";
            }
        }
    }
}