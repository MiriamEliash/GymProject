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
    public partial class Calanser : System.Web.UI.Page
    {
        DayTimeLogic dt = new DayTimeLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Repeater1.DataSource = CreateDataSource();
                Repeater1.DataBind();
            }
        }
        public DataView CreateDataSource()
        {
            DataSet ds = dt.show(code); 
            DataTable dt = ds.Tables[0]; //הטבלה שקיבלנו
            // Create sample data for the DataList control.
            DataTable ndt = new DataTable();
            DataRow dr = null; //טבלה חדשה שאנחנו בונים
            int hour = 0;
            ndt.Columns.Add(new DataColumn("SetHour", typeof(Int32)));
            ndt.Columns.Add(new DataColumn("Sunday", typeof(Int32)));
            ndt.Columns.Add(new DataColumn("Monday", typeof(Int32)));
            ndt.Columns.Add(new DataColumn("Tuesday", typeof(Int32)));
            ndt.Columns.Add(new DataColumn("Wednesday", typeof(Int32)));
            ndt.Columns.Add(new DataColumn("Thursday", typeof(Int32)));
            ndt.Columns.Add(new DataColumn("Friday", typeof(Int32)));
            ndt.Columns.Add(new DataColumn("Saturday", typeof(Int32)));

            int day = 0;

            foreach (DataRow row in dt.Rows)
            {
                string value = row["hour"].ToString();
                DateTime timeConvert;
                DateTime.TryParse(value, out timeConvert);
                int time;
                time = (int)timeConvert.TimeOfDay.TotalMilliseconds / 3600000;
                if (hour != time)
                {
                    dr = ndt.NewRow();
                    dr[0] = time;
                    hour = time;
                    ndt.Rows.Add(dr);
                }

                string dayValue = row["day"].ToString();
                day = Int32.Parse(dayValue);
                // string s = s + "what i get from query";
                dr[day] = dr[day].ToString() + "</br> <a href='RegisterPage.aspx'>" + row["Code"] + "</a>";

            }
            DataView dv = new DataView(ndt);
            return dv;
        }





        protected void Button1_Click(object sender, EventArgs e)
        {
            string code = (string)(sender as Button).CommandName;
            Response.Redirect("Charge.aspx?code=" + code);
        }
    }
}