using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GymProject.App_Code
{
    public class ChargeLogic
    {
        DAL dal = new DAL();

        public bool check(string id)

        {//בודקת אם נשאר למנוי חוגים
            string sql = String.Format("SELECT Charge.ID ,Charge.numUsedClasses, Charge.numTotalClasses FROM Charge WHERE Charge.numUsedClasses = Charge.numTotalClasses WHERE Charge.ID='{0}'", id);
            return dal.excuteQuery(sql).Tables[0].Rows.Count != 0;
        }

        public bool newClass(string ID , int numUsedClasses, int numTotalClasses)
        {
            if (check(ID))//במידה וסיים את מלאי החוגים
            {
                string sql1 = String.Format("INSERT INTO Charge (ID,numUsedClasses,numTotalClasses) VALUES ('{0}',{1},{2})", ID, numUsedClasses, numTotalClasses);
                DataSet ds = dal.excuteQuery(sql1);
                return true;
            }
            else
            {
                return false;
            }

        }


        public void updateCharge( int ID, int numTotalClasses)
        {
            string sql = string.Format(("UPDATE Charge SET [numTotalClasses]={0},[numUsedClasses]={1} WHERE ID='{2}'"), numTotalClasses,0, ID);
            dal.excuteQuery(sql);
        }

    }
}