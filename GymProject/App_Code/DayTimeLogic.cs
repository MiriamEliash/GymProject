using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GymProject.App_Code
{
    public class DayTimeLogic
    {
        DAL dal = new DAL();

        public bool newClass( int codeClassTeacher, int day, DateTime hour)
        {
            if (!check(day, hour))//במידה ושם המשתמש ותעודת הזהות לא תפוסים
            {
                string sql1 = String.Format("INSERT INTO DayTime ([codeClassTeacher],[day],[hour]) VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}')", codeClassTeacher, day, hour);
                DataSet ds = dal.excuteQuery(sql1);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool check(int day, DateTime hour)
        {//מקבלת סיסמא מחזירה אמת אם קיימת במערכת ושקר אחרת
            string sql = String.Format("SELECT DayTime.day FROM DayTime WHERE DayTime.day ='{0}' and DayTime.hour ='{1}'", day, hour);
            return dal.excuteQuery(sql).Tables[0].Rows.Count != 0;
        }



        public DataSet getDayByCodeClassTeacher(int code)
        {
            string sql = string.Format(("SELECT DayTime.day FROM DayTime WHERE DayTime.codeClassTeacher={0}"), code);
            return dal.excuteQuery(sql);
        }

        public DataSet getHourByCodeClassTeacher(int code,int day)
        {
            string sql = string.Format(("SELECT DayTime.hour FROM DayTime WHERE DayTime.codeClassTeacher={0} AND DayTime.day={1}"), code,day);
            return dal.excuteQuery(sql);
        }

    }
}