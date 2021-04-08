using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Insurance.App_Code
{
    public class CustomersLogic
    {
        DAL dal = new DAL();
        //[WebMethod]
        public bool newUser(string Id, string FirstName, string LastName, string PhoneNumber, string OrganizationId)
        {
            if (!checkUser(Id, OrganizationId))//במידה ושם המשתמש ותעודת הזהות לא תפוסים
            {
                string sql1 = String.Format("INSERT INTO Customers (ID, FirstName, LastName, PhoneNumber, OrganizationId) VALUES ('{0}', '{1}','{2}','{3}','{4}')", Id, FirstName, LastName, PhoneNumber, "6044");
                DataSet ds = dal.excuteQuery(sql1);
                return true;
            }
            else
            {
                return false;
            }

        }
       // [WebMethod]
        public bool checkUser(string Id, string OrganizationId)
        {//מקבלת סיסמא מחזירה אמת אם קיימת במערכת ושקר אחרת
            string sql = String.Format("SELECT Customers.ID FROM Customers WHERE Customers.ID ='{0}' and Customers.OrganizationId ='{1}'", Id, OrganizationId);
            return dal.excuteQuery(sql).Tables[0].Rows.Count != 0;
        }
    }
}