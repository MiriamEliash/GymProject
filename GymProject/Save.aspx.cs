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
        DayTimeLogic dtl = new DayTimeLogic();
        string id;
     

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //להציג- האם אתה מאשר את החוג שבחרת.
            {
                string s = Request.QueryString["data"];
                if(!string.IsNullOrEmpty(s))
                {
                    string[] arr = s.Split('*'); //כל פעם שיש כוכבית- לשים את מה שהיה לפני בתוך תא
                    string all = "Do you want to sign up to  " + arr[0] + "  with  " + arr[1] + " at:" + arr[2] + ", " + arr[3];
                    Label1.Text = all;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)  //אם מאשר- להכניס לטבלה של הזמנת חוגים ולעדכן את מספר החוגים המשומשים
        {
            OrderClassesLogic ul = new OrderClassesLogic();

            //if יש מקום
            // ul.newUser(First_name.Text, Last_name.Text, input_id.Text, Phone_number.Text, Password1.Text, 1111))
            //   Label2.Text = "you have successfuly registered!";

        }
    }
}