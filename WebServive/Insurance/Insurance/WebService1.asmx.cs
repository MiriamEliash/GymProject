using Insurance.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Insurance
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        AgentsLogic al = new AgentsLogic();
        ConnectLogic co = new ConnectLogic();
        CustomersLogic cu = new CustomersLogic();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public DataSet getAll(string OrganizationId)
        {
            return co.getAllCustomers(OrganizationId);
        }

        [WebMethod]
        public DataSet getApproveCustomers(string OrganizationId)
        {
            return co.getApproveCustomers(OrganizationId);
        }

        [WebMethod]
        public DataSet getNotApproveCustomers(string OrganizationId)
        {
            return co.getNotApproveCustomers(OrganizationId);
        }

        [WebMethod]
        public void change(string ID)
        {
            co.updateCustomer(ID);
        }
    }
}
