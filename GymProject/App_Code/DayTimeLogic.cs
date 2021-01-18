﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GymProject.App_Code
{
    public class DayTimeLogic
    {
        DAL dal = new DAL();

        public bool newClass(int code, int codeClassTeacher, int day, DateTime hour)
        {
            if (!check(day, hour, codeClassTeacher))//במידה ושם המשתמש ותעודת הזהות לא תפוסים
            {
                string sql1 = String.Format("INSERT INTO DayTime (code,codeClassTeacher,day,hour) VALUES ('{0}','{1}','{2}','{3}')", code, codeClassTeacher, day, hour);
                DataSet ds = dal.excuteQuery(sql1);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool check(int day, DateTime hour, int codeClassTeacher)

        {//בודקת אם יש מדריך באותו יום ושעה
            string sql = String.Format("SELECT DayTime.codeClassTeacher FROM DayTime WHERE DayTime.day ='{0}' and DayTime.hour ='{1}'", day, hour, codeClassTeacher);
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
        public DataSet show(int code)
        {
            //שם המדריך מהקוד ממדריכים
            //שם החוג מהקוד מחוגים

            //  string nameT = getNameByCodeClassTeacher(int codeT);
            //   string nameC = getInstructorsByClass(int codeT);

             string sql = string.Format(("SELECT * FROM DayTime  WHERE DayTime.codeClassTeacher ='{0}' DayTime.day ='{1}' AND DayTime.hour='{2}' "), code);
            return dal.excuteQuery(sql);
        }

        public DataSet show2(int code)
        {

            string sql = string.Format(("SELECT Classes.name AS nameClass FROM Classes INNER JOIN TeacherClass ON  Classes.CodeClass =TeacherClass.CodeClass WHERE CodeClassTeacher={0}"), code);
            return dal.excuteQuery(sql);
        }

        /* public DataSet getNameByCodeClassTeacher(int CodeClassTeacher)
         {
             string sql = string.Format(("SELECT Classes.name AS nameClass FROM Classes INNER JOIN TeacherClass ON  Classes.CodeClass =TeacherClass.CodeClass WHERE CodeClassTeacher={0}"), CodeClassTeacher);
              return dal.excuteQuery(sql);
         }
        */



    }
}