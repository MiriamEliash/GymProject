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
        string nameClass;
        string fullName;
        string day;
        DateTime hour;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //להציג- האם אתה מאשר את החוג שבחרת.
            {
                Label1.Text = "Instructor is already exist";
                Label2.Text = "Instructor is already exist";
                Label3.Text = "Instructor is already exist";
                Label4.Text = "Instructor is already exist";
            }

            //אם מאשר- להכניס לטבלה של הזמנת חוגים ולעדכן את מספר החוגים המשומשים

        }


    }
}