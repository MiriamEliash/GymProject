using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GymProject.App_Code
{
    public class ClassesLogic
    {
        DAL dal = new DAL();
        public DataSet getAllClasses()
        {
            string sql = "SELECT * FROM Classes";
            return dal.excuteQuery(sql);
        }

        public void updateClass(double code, int numPeople)
        {
            string sql = "UPDATE Classes SET number of people=" + numPeople + "WHERE code class=" + code;
            dal.excuteQuery(sql);
        }


    }
}