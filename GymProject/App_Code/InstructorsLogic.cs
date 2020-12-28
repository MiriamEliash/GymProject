using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GymProject.App_Code
{
    public class InstructorsLogic
    {
        DAL dal = new DAL();

        public DataSet getAllInstructors()
        {
            string sql = "SELECT * FROM Instructors";
            return dal.excuteQuery(sql);
        }

        public void updateInstructor(double Salary, string ID)
        {
            string sql = string.Format(("UPDATE Instructors SET [Salary]={0} WHERE ID='{1}'"), Salary,  ID);
            dal.excuteQuery(sql);
        }

        public void deleteInstructor(string ID)
        {//delete Instructors
            string sql = string.Format(("DELETE * FROM Instructors WHERE ID='{0}'"), ID);
            dal.excuteQuery(sql);
        }

        public bool newInstructor( string ID, string FirstName, string LastName, double Salary, int PhoneNumber, int pass, int BranchCode)
        {
            if (!checkIdInstructor(ID))
            {
                string sql1 = String.Format("INSERT INTO Instructors ([ID],[First name],[Last name],[Phone number],[Salary],[Pass],[Branch Code]) VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}')", ID, FirstName, LastName, Salary, PhoneNumber, pass, BranchCode);
                DataSet ds = dal.excuteQuery(sql1);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool checkIdInstructor(string ID)
        {//מקבלת סיסמא מחזירה אמת אם קיימת במערכת ושקר אחרת
            string sql = String.Format("SELECT ID FROM Instructors WHERE Instructors.ID ='{0}'", ID);
            return dal.excuteQuery(sql).Tables[0].Rows.Count != 0;
        }

    }
}