using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GymProject.App_Code
{
    public class ClassesLogic
    {
        private DAL dal = new DAL();
        public DataSet getAllClasses()
        {
            string sql = "SELECT * FROM Classes";
            return dal.excuteQuery(sql);
        }
        public DataSet getName()
        {
            string sql = "SELECT name FROM Classes";
            return dal.excuteQuery(sql);
        }

        public bool newClasses(int CodeClass, string name, int numberOfPeople)
        {
            if (!checkCodeClass(CodeClass))
            {
                string sql1 = String.Format("INSERT INTO Classes (CodeClass, name, [number of people]) VALUES ('{0}', '{1}','{2}')", CodeClass, name, numberOfPeople);
                DataSet ds = dal.excuteQuery(sql1);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool checkCodeClass(int CodeClass)
        {//מקבלת סיסמא מחזירה אמת אם קיימת במערכת ושקר אחרת
            string sql = String.Format("SELECT CodeClass FROM Classes WHERE Classes.CodeClass ={0}", CodeClass);
            return dal.excuteQuery(sql).Tables[0].Rows.Count != 0;
        }


        public void updateClass(double code, int numPeople)
        {
            string sql = "UPDATE Classes SET number of people=" + numPeople + "WHERE CodeClass class=" + code;
            dal.excuteQuery(sql);
        }

        public DataSet getNameByCodeClassTeacher(int CodeClassTeacher)
        {
             string sql = string.Format(("SELECT Classes.name FROM Classes INNER JOIN TeacherClass ON  Classes.CodeClass =TeacherClass.CodeClass WHERE CodeClassTeacher={0}"), CodeClassTeacher);
              return dal.excuteQuery(sql);
        }

        public void deleteClass(int CodeClass)
        {//delete Instructors
            string sql = string.Format(("DELETE * FROM Classes WHERE CodeClass={0}"), CodeClass);
            dal.excuteQuery(sql);
        }

        //  public DataSet getInstructorsByClass(int codeClass, string Instructors)
        // {
        //     int A = codeClass;
        //     int B = Int32.Parse(Instructors);
        //    string sql = "SELECT * FROM TeacherClass WHERE codeClass(TeacherClass.[Code class]) IN (" + A + ") AND Instructors(TeacherClass.id) IN (" + B + ")";
        //    DataSet ds = dal.excuteQuery(sql);
        //    return ds;
        // }
    }
}