using GymProject.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GymProject
{
    public partial class AddInstructor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            InstructorsLogic dl = new InstructorsLogic();
            if (!dl.newInstructor(inputId.Text, inputFirstName.Text, inputLastName.Text, double.Parse(inputSalary.Text), int.Parse(inputPhoneNum.Text), int.Parse(pass.Text), 1111))
                Label2.Text = "Instructor is already exist";
            else
                Label2.Text = "you have successfuly add new instructor!";
        }
    }
}