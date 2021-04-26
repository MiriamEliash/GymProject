using GymProject.localhost;
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
        WebService1 ws = new WebService1();
        protected void Page_Load(object sender, EventArgs e)
          {

              if (!IsPostBack)
              {
                  GridView1.DataSource = ws.getAll("6044");
                  GridView1.DataBind();
              }


          }

          protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
          {//שינוי?

          }

          protected void Button1_Click(object sender, EventArgs e)
          {
              if (!IsPostBack)
              {
                 GridView1.DataSource = ws.getApproveCustomers("6044");
                  GridView1.DataBind();
              }
          }

          protected void Button2_Click(object sender, EventArgs e)
          {
              if (!IsPostBack)
              {
                  GridView1.DataSource = ws.getNotApproveCustomers("6044");
                  GridView1.DataBind();
              }
          }

          protected void Button3_Click(object sender, EventArgs e)
          {

                  //UserServise us = new UserServise();

                  foreach (GridViewRow row in GridView1.Rows)
                  {
                      if (row.RowType == DataControlRowType.DataRow)
                      {
                          CheckBox chkRow = (row.Cells[4].FindControl("CheckBox1") as CheckBox);
                          if (chkRow.Checked)
                          {
                              string storid = row.Cells[0].Text;
                           //   int storname = Int32.Parse(row.Cells[2].Text);
                           //   string state = row.Cells[3].Text;
                           //   data = data + storid + " ,  " + storname + " , " + state + "<br>";
                              ws.change(storid);
                          }
                      }
                  }
                

          }
    }
}