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
    public partial class ClassTime : System.Web.UI.Page
    {
        ClassesLogic des = new ClassesLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = des.getAllClasses();
            for (int b = 0; b < ds.Tables[0].Rows.Count; b++)
            {
                codeClass.Items.Insert(Int32.Parse(ds.Tables[0].Rows[b].ItemArray[0].ToString()), ds.Tables[0].Rows[b].ItemArray[1].ToString());
            }

           // DataSet da= des.getInstructorsByClass(codeClass.SelectedValue)
           // for (int i = 0; i < da.Tables[0].Rows.Count; i++)
            //{
            //    Instructors.Items.Insert(i, ds.Tables[0].Rows[i].ItemArray[0].ToString());
           // }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}