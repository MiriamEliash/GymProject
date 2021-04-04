using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymProject
{
    public partial class Insurance : System.Web.UI.Page
    {
       // wsInsurance es = new wsInsurance();
        Insurance esI = new Insurance();
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            if (!IsPostBack)
            {
                GridView1.DataSource = esI.getAll("6044");
                GridView1.DataBind();
            }
            */

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}