using GymProject.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymProject
{
    public partial class Calanser : System.Web.UI.Page
    {
        DayTimeLogic dt = new DayTimeLogic();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string code = (string)(sender as Button).CommandName;
            Response.Redirect("Charge.aspx?code=" + code);
        }
    }
}