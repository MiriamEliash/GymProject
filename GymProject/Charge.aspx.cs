using GymProject.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymProject
{
    public partial class Charge : System.Web.UI.Page
    {
        DayTimeLogic dt = new DayTimeLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
             if(! IsPostBack)
              {
                  string code = Request.QueryString["code"];
                // DataSet dt=dt.____ //זימון השאילתה
                // שם הפקד.text = Tables[0].rows[0][שם השדה].ToString(); 
              }
            
        }
    }
}