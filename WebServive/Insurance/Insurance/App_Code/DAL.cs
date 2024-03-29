﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Insurance.App_Code
{
    public class DAL
    {

        OleDbConnection myConnection;
        const string FILE_NAME = "WebService.accdb";
        private SqlCommand command = new SqlCommand();

        public DAL()
        {
            string location = HttpContext.Current.Server.MapPath("~/App_Data/" + FILE_NAME);
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; data source=" + location;
            myConnection = new OleDbConnection(connectionString);
        } 

        //פעולההמפעילהאתהשאילתאשנשלחתעלבסיסהנתונים
        public DataSet excuteQuery(String sql)
        {
            DataSet dataset = new DataSet();
            try
            {
                myConnection.Open();
                string Sql = sql;
                OleDbCommand myCmd = new OleDbCommand(Sql, myConnection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = myCmd;
                adapter.Fill(dataset);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                myConnection.Close();
            }
            return dataset;
        }

    }
}