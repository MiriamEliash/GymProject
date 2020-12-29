using GymProject.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymProject
{
    public partial class Login : System.Web.UI.Page
    {
        internal static string aspx;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SubscribersLogic ul = new SubscribersLogic();
            if (!(ul.isUser( pass.Text, ID.Text)))
                Label1.Text = "id or passwod are wrong";
            else
            {
                Label1.Text = "you have successfully loggin";
                Response.Redirect("HomeSubscribers.aspx");
            }
               
        }
    }
}