﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Insider_Email
    {
        public static int Create(List<DataObjects.Insider_Email.XML> lsArray)
        {
            int result = -1;
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                conn.BeginTransaction();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter { ParameterName = "@XML", SqlDbType = SqlDbType.Xml, Value = Utilities.XML.GetXMLFromObject(lsArray) });
                result = conn.ExecuteNonQuery("sp_INSIDER_Email_Webhook_Create", lsInput);
                conn.Commit();
            }
            catch (Exception ex) { conn.RollBack(); result = -1; Utilities.FileLog.WriteFileLog("DataAccess-->INSIDER_Email-->Create::" + ex.Message); }
            finally { conn.Close(); }
            return result;
        }

    }
}
