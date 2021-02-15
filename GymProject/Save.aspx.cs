using GymProject.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymProject
{
    public partial class Save : System.Web.UI.Page
    {
        OrderClassesLogic ul = new OrderClassesLogic();
        
        DayTimeLogic dtl = new DayTimeLogic();
        ChargeLogic cl = new ChargeLogic();
        string ChargeId;
        int CodeDayTime;



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //להציג- האם אתה מאשר את החוג שבחרת.
            {
                
                if(!string.IsNullOrEmpty(Request.QueryString["data"]))
                {
                    string s = Request.QueryString["data"];
                    string[] arr = s.Split('*'); //כל פעם שיש כוכבית- לשים את מה שהיה לפני בתוך תא
                    string all = "Do you want to sign up to  " + arr[0] + "  with  " + arr[1] + " at:" + arr[2] + ", " + arr[3];
                    Label1.Text = all;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)  //אם מאשר- להכניס לטבלה של הזמנת חוגים ולעדכן את מספר החוגים המשומשים
        {
           
            if (!string.IsNullOrEmpty(Request.QueryString["data"]))
            {
              
                //if יש מקום

                string s = Request.QueryString["data"];
                string[] arr = s.Split('*'); //כל פעם שיש כוכבית- לשים את מה שהיה לפני בתוך תא  

           /*   ChargeId = cl.whatIdCharge(Session["Id"].ToString());
                CodeDayTime = Int32(arr[4]);
                int NUM = Int32(arr[5]);
                 if (isOk(CodeDayTime,NUM))
                  {
                    Label2.Text = "dont have space in this class";
                  }
                  else
                   {
                    // ul.newUser( ChargeId ,CodeDayTime);
                    Label2.Text = "you have successfuly registered!";
                   }
                */



            }
           
             

        }
    }
}