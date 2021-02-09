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
      /*  public bool isOk(int code, int num)
        {//השיטה תבדוק האם יש נגמר המקום בחוג- מקבלים מספר מקסימלי משאילתה קודמת ומשתמשים
            if (checkNum(code)+1> num)
            {
                return true;
            }
            else
                return false;
        }
        public int checkNum(int code)
        {//  מקבלת ומחזירה את מספר המשתתפים בחוג הקיים
            string sql = "SELECT COUNT(OrderClasses.) FROM  OrderClasses WHERE  OrderClassesCodeDayTime={0}", code;
            DataSet ds = dal.excuteQuery(sql);
            string s = ds.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
            return s;
        }
       */


        //שאילתה שמחזירה לפי הקוד-את שם החוג, שם המדריך, יום ושעה

    }
}