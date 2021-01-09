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
      //  InstructorsLogic Ins = new InstructorsLogic();
        DayTimeLogic dt = new DayTimeLogic();
        TeacherClassLogic dc = new TeacherClassLogic();


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
                  DataSet ds = dc.getInstructorsByClass(x);
          
                     fullName.DataSource = ds;
                     fullName.DataBind();
            
                     fullName.DataTextField = "fullName";
                     fullName.DataValueField = "Code";
           
                     fullName.DataBind();
                     fullName.Items.Insert(0, "בחר");
                 
        }


       
        //protected void fullName_SelectedIndexChanged(object sender, EventArgs e)
       // {
           // int x = Int32.Parse(fullName.SelectedValue);
          //  DataSet ds = dt.getDayByCodeClassTeacher(x);

            //    Day.DataSource = ds;
            //    Day.DataBind();

             //   Day.DataTextField = "Day";
             //   Day.DataValueField = "Day";
            
             //   Day.DataBind();
             //   Day.Items.Insert(0, "בחר");
            
       // }

       // protected void Day_SelectedIndexChanged(object sender, EventArgs e)
       // {
          //  int code = Int32.Parse(fullName.SelectedValue);
           // int day= Int32.Parse(Day.SelectedValue);
           // DataSet ds = dt.getHourByCodeClassTeacher(code,day);

          
             //   Hour.DataSource = ds;
             //   Hour.DataBind();

             //   Hour.DataTextField = "Hour";
             //   Hour.DataValueField = "Hour";

             //   Hour.DataBind();
              //  Hour.Items.Insert(0, "בחר");
            
       // }


      //  protected void Button1_Click(object sender, EventArgs e)
      //  {
      //     
      //      if (!dt.newClass(int.Parse(fullName.SelectedValue.Text), int.Parse(Day.Text), DateTime.Parse(Hour.Text)))
      //          Label2.Text = "class already exist";
      //      else
      //      {
      //          Label2.Text = "you have successfuly add new class!";
      //          Response.Redirect("ClassTime.aspx");
      //      }
      //  }

    }
}