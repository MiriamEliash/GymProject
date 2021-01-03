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
        InstructorsLogic Ins = new InstructorsLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = des.getAllClasses();
            if (!IsPostBack)
            {
                codeClass.DataSource = ds;
                codeClass.DataBind();

                codeClass.DataTextField = "name";
                codeClass.DataValueField = "CodeClass";

                codeClass.DataBind();
                codeClass.Items.Insert(0, "בחר");
            }

        }
        protected void codeClass_SelectedIndexChanged(object sender, EventArgs e)
        {
                 int x = Int32.Parse(codeClass.SelectedValue);
                  DataSet ds = Ins.getInstructorsByClass(x);
           
                 if (!IsPostBack)
                 {
                     fullName.DataSource = ds;
                     fullName.DataBind();
            
                     fullName.DataTextField = "[fullName]";
                     fullName.DataValueField = "[ID]";
           
                     fullName.DataBind();
                     fullName.Items.Insert(0, "בחר");
                 }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void fullName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}