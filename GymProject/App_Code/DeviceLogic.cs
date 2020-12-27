using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace GymProject.App_Code
{
    public class DeviceLogic
    {
        DAL dal = new DAL();
        public DataSet getAllDevice()
        {
            string sql = "SELECT * FROM Devices";
            return dal.excuteQuery(sql);
        }

        public void updateDevice(double price, string nameCompany, int code)
        {
            string sql = string.Format(("UPDATE Devices SET [Facility cost]={0}, [Freight company]='{1}' WHERE [Code device]={2}"), price, nameCompany, code);
            dal.excuteQuery(sql);
        }
        public void deleteDevices(int Code)
        {//delete Devices
            string sql = string.Format(("DELETE * FROM Devices WHERE [Code device]={0}"), Code);
            dal.excuteQuery(sql);
        }

        public bool newDevice(int CodeDevice, string DeviceName, double FacilityCost, string FreightCompany, int BranchCode)
        {
            if (!checkCodeDevice(CodeDevice))
            {
                string sql1 = String.Format("INSERT INTO Devices ([Code device],[Device name],[Facility cost],[Freight company],[Branch Code]) VALUES ('{0}', '{1}','{2}','{3}','{4}')", CodeDevice, DeviceName, FacilityCost, FreightCompany, BranchCode);
                DataSet ds = dal.excuteQuery(sql1);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool checkCodeDevice(int CodeDevice)
        {//מקבלת סיסמא מחזירה אמת אם קיימת במערכת ושקר אחרת
            string sql = String.Format("SELECT [Code device] FROM Devices WHERE Devices.[Code device] ={0}", CodeDevice);
            return dal.excuteQuery(sql).Tables[0].Rows.Count != 0;
        }

    }
}