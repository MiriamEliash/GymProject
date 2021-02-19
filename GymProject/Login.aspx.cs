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
            SubscribersLogic sl = new SubscribersLogic();
            InstructorsLogic il = new InstructorsLogic();
            ManagerLogic ml = new ManagerLogic();

            if (sl.checkUser( pass.Text, ID.Text))
            {
                Label1.Text = "you have successfully loggin";
                Session["Id"] = ID.Text;
               // Session["nameUser"] = "אורח";
                Session["typeAdmin"] = "Subscriber";
                Response.Redirect("HomeSubscribers.aspx");

            }
            else
            {
                if (il.isInstructors(pass.Text, ID.Text))
                {
                    Label1.Text = "you have successfully loggin";
                    Session["Id"] = ID.Text;
                    // Session["nameUser"] = "אורח";
                    Session["typeAdmin"] = "Instructor";
                    Response.Redirect("HomeSubscribers.aspx");
                }
                else
                {
                    if (ml.isManager(pass.Text, ID.Text))
                    {
                        Label1.Text = "you have successfully loggin";
                        Session["Id"] = ID.Text;
                        // Session["nameUser"] = "אורח";
                        Session["typeAdmin"] = "Manager";
                        Response.Redirect("HomeSubscribers.aspx");
                    }
                    else
                    {
                        Label1.Text = "id or passwod are wrong";
                    }

                }
            }

        }
       
    }
}