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