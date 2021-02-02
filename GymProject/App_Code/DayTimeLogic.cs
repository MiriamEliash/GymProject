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

        public bool newClass(int code, int codeClassTeacher, int day,  TimeSpan hour)
        {
            if (!check(day, hour, codeClassTeacher))//במידה ושם המשתמש ותעודת הזהות לא תפוסים
            {
                string sql1 = String.Format("INSERT INTO DayTime (code,codeClassTeacher,day1,hour1) VALUES ({0},{1},{2},#{3}#)", code, codeClassTeacher, day, hour);
                DataSet ds = dal.excuteQuery(sql1);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool check(int day, TimeSpan hour, int codeClassTeacher)

        {//בודקת אם יש מדריך באותו יום ושעה
            string sql = String.Format("SELECT DayTime.codeClassTeacher FROM DayTime WHERE DayTime.day1 ={0} and DayTime.hour1 =#{1}#", day, hour, codeClassTeacher);
            return dal.excuteQuery(sql).Tables[0].Rows.Count != 0;
        }

        public string getMaxCode()
        {//מחזירה את הערך הגבוה ביותר- המספור האוטומטי
            string sql = string.Format(("SELECT MAX(code) FROM (DayTime)"));
            DataSet ds = dal.excuteQuery(sql);
            string s = ds.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
            return s;
        }

        public DataSet getDayByCodeClassTeacher(int code)
        {
            string sql = string.Format(("SELECT DayTime.day FROM DayTime WHERE DayTime.codeClassTeacher={0}"), code);
            return dal.excuteQuery(sql);
        }

        public DataSet getHourByCodeClassTeacher(int code, int day)
        {
            string sql = string.Format(("SELECT DayTime.hour FROM DayTime WHERE DayTime.codeClassTeacher={0} AND DayTime.day={1}"), code, day);
            return dal.excuteQuery(sql);
        }


        public DataSet show()
        {

            string sql = "SELECT DayTime.code, DayTime.day1, DayTime.hour1 ,Classes.name ,  Instructors.ID, Instructors.[First name]+' '+Instructors.[Last name] as fullName FROM (((DayTime INNER JOIN TeacherClass ON  DayTime.codeClassTeacher =TeacherClass.Code) INNER JOIN Classes ON Classes.CodeClass=TeacherClass.CodeClass)INNER JOIN Instructors ON Instructors.ID=TeacherClass.id) ORDER BY hour,day " ;
            //string sql = string.Format(("SELECT DayTime.code, (Classes.name AS nameClass FROM ((Classes INNER JOIN TeacherClass ON  Classes.CodeClass =TeacherClass.CodeClass) INNER JOIN DayTime ON DayTime.codeClassTeacher=TeacherClass.Code)),( Instructors.ID, Instructors.[First name]+' '+Instructors.[Last name] as fullName FROM ((Instructors INNER JOIN TeacherClass ON  Instructors.ID =TeacherClass.ID ) INNER JOIN DayTime ON DayTime.codeClassTeacher=TeacherClass.Code)), DayTime.day, DayTime.hour   WHERE DayTime.Code={0}"), code);
          
            return dal.excuteQuery(sql);
        }
/*
        public DataSet show()
        {

            string sql = "SELECT DayTime.code, DayTime.day1, DayTime.hour1 ,Classes.name ,  Instructors.ID, Instructors.[First name]+' '+Instructors.[Last name] as fullName FROM (((DayTime INNER JOIN TeacherClass ON  DayTime.codeClassTeacher =TeacherClass.Code) INNER JOIN Classes ON Classes.CodeClass=TeacherClass.CodeClass)INNER JOIN Instructors ON Instructors.ID=TeacherClass.id) ORDER BY hour,day ";
            //string sql = string.Format(("SELECT DayTime.code, (Classes.name AS nameClass FROM ((Classes INNER JOIN TeacherClass ON  Classes.CodeClass =TeacherClass.CodeClass) INNER JOIN DayTime ON DayTime.codeClassTeacher=TeacherClass.Code)),( Instructors.ID, Instructors.[First name]+' '+Instructors.[Last name] as fullName FROM ((Instructors INNER JOIN TeacherClass ON  Instructors.ID =TeacherClass.ID ) INNER JOIN DayTime ON DayTime.codeClassTeacher=TeacherClass.Code)), DayTime.day, DayTime.hour   WHERE DayTime.Code={0}"), code);

            return dal.excuteQuery(sql);
        }
*/

        /* public DataSet getNameByCodeClassTeacher(int CodeClassTeacher)
         {
             string sql = string.Format(("SELECT Classes.name AS nameClass FROM Classes INNER JOIN TeacherClass ON  Classes.CodeClass =TeacherClass.CodeClass WHERE CodeClassTeacher={0}"), CodeClassTeacher);
              return dal.excuteQuery(sql);
         }
        */



    }
}