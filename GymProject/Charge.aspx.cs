using GymProject.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymProject
{
    public partial class Charge : System.Web.UI.Page
    {
        //DayTimeLogic dt = new DayTimeLogic();    
        ChargeLogic cl = new ChargeLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             string code = Request.QueryString["code"];
             if (! IsPostBack)
             {
                 int codeC = Int32.Parse(code);
                 DataSet ds = dt.show(codeC);
                 Label2.Text = dt.Tables[0].Rows[0][0].ToString();
                 Label3.Text = dt.Tables[0].Rows[0][1].ToString();
                 Label4.Text = dt.Tables[0].Rows[0][2].ToString();
                 Label5.Text = dt.Tables[0].Rows[0][3].ToString();
             }
             */
        }
        
        protected void Button1_Click(object sender, EventArgs e)// מכניסה לאותו משתמש 
        {
           // cl.newCharge(Session["Id"].ToString(),)
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if(!cl.checkUser(Session["Id"].ToString()))
            { 
            cl.newCharge(Session["Id"].ToString(), 0, Int32.Parse(numClass.text), CardNumber.Text, DateTime.Today);
            }
            else
            {
                cl.updateCharge(Session["Id"].ToString(), 0, Int32.Parse(numClass.text));
            }
        }
    }
}