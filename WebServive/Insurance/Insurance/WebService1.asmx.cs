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
        theConnecttLogic co = new theConnecttLogic();
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
        [WebMethod]
        public bool newU(string Id, string FirstName, string LastName, string PhoneNumber, string OrganizationId)
        {
            //        newUser(string Id, string FirstName, string LastName, string PhoneNumber, string OrganizationId)

           return cu.newUser(Id, FirstName, LastName, PhoneNumber, OrganizationId);
        }
    }
}
