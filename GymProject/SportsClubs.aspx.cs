using GymProject.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymProject
{
    public partial class SportsClubs : System.Web.UI.Page
    {
        ClassesLogic dl = new ClassesLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
           // if (!IsPostBack)
          //  {
            //    GridView1.DataSource = dl.getAllClasses();
              //  GridView1.DataBind();
            //}
        }
    }
}