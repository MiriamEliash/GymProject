using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GymProject.App_Code
{
    public class SubscribersLogic
    {
        DAL dal = new DAL();
        public bool newUser(string FirstName, string LastName, string ID, string PhoneNumber, string Pass, int BranchCode)
        {
            if (!checkPass(Pass) && !checkUserName(ID))//במידה ושם המשתמש ותעודת הזהות לא תפוסים
            {
                string sql1 = String.Format("INSERT INTO Subscribers ([First name],[Last name],[ID],[Phone number],Pass,[Branch Code]  ) VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}')", FirstName, LastName, ID, PhoneNumber, Pass, BranchCode);
                DataSet ds = dal.excuteQuery(sql1);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool isUser(string pass, string ID)
        {//השיטה תבדוק האם המשתמש שמור במערכת
            if (checkPass(pass) && IdMatchPass(ID, pass))//אם תעודת הזהות קיימת
            {
                return true;
            }
            else
                return false;
        }

        public bool isManager(string ID)
        {//מקבלת תעודת זהות מחזירה אמת אם המשתמש מנהל ושקר אחרת
            string sql = String.Format("SELECT ID FROM Manager WHERE(Manager.ID) ='{0}'", ID);
            return dal.excuteQuery(sql).Tables[0].Rows.Count != 0;
        }
        public bool isInstructors(string ID)
        {//מקבלת תעודת זהות מחזירה אמת אם המשתמש מדריך ושקר אחרת
            string sql = String.Format("SELECT ID FROM Instructors WHERE(Instructors.ID) ='{0}'", ID);
            return dal.excuteQuery(sql).Tables[0].Rows.Count != 0;
        }



        public bool checkPass(string pass)
        {//מקבלת סיסמא מחזירה אמת אם קיימת במערכת ושקר אחרת
            string sql = String.Format("SELECT Subscribers.Pass FROM Subscribers WHERE Subscribers.Pass ='{0}'", pass);
            return dal.excuteQuery(sql).Tables[0].Rows.Count != 0;
        }
        public bool checkUserName(string ID)
        {//מקבלת שם משתמש (ID) מחזירה אמת אם קיים במערכת ושקר אחרת
            string sql = String.Format("SELECT Subscribers.ID FROM Subscribers WHERE Subscribers.ID ='{0}' ", ID);
            return dal.excuteQuery(sql).Tables[0].Rows.Count != 0;
        }
        public bool IdMatchPass(string ID, string pass)
        {
            string sql = String.Format("SELECT ID FROM Subscribers WHERE Subscribers.ID ='{0}' AND Subscribers.Pass='{1}' ", ID, pass);
            return dal.excuteQuery(sql).Tables[0].Rows.Count != 0;
        }


        public DataSet getAllSubscribers()
        {
            string sql = "SELECT * FROM Subscribers";
            return dal.excuteQuery(sql);
        }
        public void deleteUser(string ID)
        {//delete User
            string sql = string.Format(("DELETE * FROM Subscribers WHERE ID='{0}'"), ID);
            dal.excuteQuery(sql);
        }
    }
}