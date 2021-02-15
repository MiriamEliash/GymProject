using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GymProject.App_Code
{
    public class OrderClassesLogic
    {
        DAL dal = new DAL();

         public void newUser(int chargeId, int CodeDayTime)
         {

             string sql1 = String.Format("INSERT INTO OrderClasses (chargeId,CodeDayTime) VALUES ('{0}', '{1}')", chargeId, CodeDayTime);
              dal.excuteQuery(sql1);
              sql1 = string.Format("SELECT MAX(Code) FROM OrderClasses WHERE chargeId='{0}'", chargeId);
              DataSet ds = dal.excuteQuery(sql1);
         }


           public bool isOk(int CodeDayTime, int num)
           {//השיטה תבדוק האם יש נגמר המקום בחוג- מקבלים מספר מקסימלי משאילתה קודמת ומשתמשים
               if (checkNum(CodeDayTime)+1> num)
               {
                   return true;
               }
               else
                   return false;
           }
           public int checkNum(int CodeDayTime)
           {//  מקבלת ומחזירה את מספר המשתתפים בחוג הקיים
               string sql = "SELECT COUNT(OrderClasses.) FROM  OrderClasses WHERE  OrderClasses.CodeDayTime={0}", code;
               DataSet ds = dal.excuteQuery(sql);
               string s = ds.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
               return s;
           }

   



    }
}