using GymProject.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymProject
{
    public partial class Classes : System.Web.UI.Page
    {
        ClassesLogic dl = new ClassesLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = dl.getAllClasses();
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string numPeople = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text;
            dl.updateClass(int.Parse(numPeople), Int32.Parse(GridView1.Rows[e.RowIndex].Cells[0].Text));
            GridView1.EditIndex = -1;
            GridView1.DataSource = dl.getAllClasses();
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.DataSource = dl.getAllClasses();
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }
    }
}