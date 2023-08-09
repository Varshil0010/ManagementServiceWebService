using BusinessObject;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for ManagementService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ManagementService : System.Web.Services.WebService
    {

        [WebMethod]
        public int insertEmployee(EmployeeBO employeeBO)
        {
            EmployeeDA dataAccess = new EmployeeDA();
            var result = dataAccess.insertEmployee(employeeBO);

            return result;
        }

        [WebMethod]
        public int updateEmployee(EmployeeBO employeeBO)
        {
            EmployeeDA dataAccess = new EmployeeDA();
            var result = dataAccess.updateEmployee(employeeBO);

            return result;
        }

        [WebMethod]
        public int deleteEmployee(EmployeeBO employeeBO)
        {
            EmployeeDA dataAccess = new EmployeeDA();
            var result = dataAccess.deleteEmployee(employeeBO);

            return result;
        }
    }
}
