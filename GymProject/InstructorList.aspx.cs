using GymProject.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymProject
{
    public partial class InstructorList : System.Web.UI.Page
    {
        OrderClassesLogic Ol = new OrderClassesLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string s = Request.QueryString["data"];
                if (!string.IsNullOrEmpty(s))
                {
                    GridView1.DataSource = Ol.showNames(s);
                    GridView1.DataBind();
                }

            }
        }
    }
}