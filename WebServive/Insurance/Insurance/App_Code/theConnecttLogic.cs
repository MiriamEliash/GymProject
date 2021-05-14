using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Insurance.App_Code
{
    public class theConnecttLogic 
    {
        DAL dal = new DAL();
        public DataSet getAllCustomers( string OrganizationId)// מציגה את כל המשתמשים של המכון כושר
        {
            string sql = string.Format(("SELECT theConnect.IdCustomer, theConnect.IsApprove, Customers.ID, Customers.FirstName, Customers.LastName, Customers.PhoneNumber, Customers.OrganizationId FROM theConnect INNER JOIN Customers ON theConnect.IdCustomer=Customers.ID WHERE Customers.OrganizationId='{0}' "), OrganizationId);
            return dal.excuteQuery(sql);
        }

        public DataSet getApproveCustomers(string OrganizationId)// מציגה את  המשתמשים המאושרים של המכון כושר
        {
            string sql = string.Format(("SELECT theConnect.IdOrganization, theConnect.IdCustomer, theConnect.IsApprove, Customers.ID,Customers.FirstName, Customers.LastName ,Customers.PhoneNumber AS PhoneNumber FROM theConnect INNER JOIN Customers ON theConnect.IdCustomer=Customers.ID WHERE(theConnect.IdOrganization ='{0}' AND Customers.IsApprove=True) "), OrganizationId);
            return dal.excuteQuery(sql);
        }
        public DataSet getNotApproveCustomers(string OrganizationId)// מציגה את  המשתמשים הלא מאושרים של המכון כושר
        {
            string sql = string.Format(("SELECT theConnect.IdCustomer, theConnect.IsApprove AS IsApprove ,Customers.ID AS id,Customers.FirstName AS firstName, Customers.LastName AS lastName,Customers.PhoneNumber AS PhoneNumber, Customers.OrganizationId FROM theConnect INNER JOIN Customers ON theConnect.IdCustomer=Customers.ID WHERE(Customers.OrganizationId='{0}' AND ((Customers.IsApprove)=False)) "), OrganizationId);
            return dal.excuteQuery(sql);
        }

        public void updateCustomer(string ID)
        {
            string sql = string.Format(("UPDATE theConnect SET theConnect.IsApprove =True WHERE IdCustomer ='{0}'"), ID);
            dal.excuteQuery(sql);
        }

       

    }
}