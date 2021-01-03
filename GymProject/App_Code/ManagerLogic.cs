using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymProject.App_Code
{
    public class ManagerLogic
    {
        DAL dal = new DAL();


        public bool isManager(string pass, string ID)
        {//מקבלת סיסמא מחזירה אמת אם קיימת במערכת ושקר אחרת
            string sql = String.Format("SELECT Manager.Pass FROM Manager WHERE Manager.Pass ='{0}' and Manager.ID ='{1}'", pass, ID);
            return dal.excuteQuery(sql).Tables[0].Rows.Count != 0;
        }
    }
}