using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CallCenter
    {
        public static int Create(string phone, string extension, string callid, int duration, string status, string recordingfile)
        {
            int result = -1;
            DataProvider.ConnectionAPI conn = null;
            try
            {
                conn = new DataProvider.ConnectionAPI();
                conn.Open();
                conn.BeginTransaction();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@callid", callid));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@phone", phone));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@extension", extension));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@status", status));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@recordingfile", recordingfile));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@timecalling", duration));
                result = conn.ExecuteNonQuery("sp_CallCenter_Create", lsInput);
                conn.Commit();
            }
            catch (Exception ex) { conn.RollBack(); result = -1; Utilities.FileLog.WriteFileLog("DataAccess-->sp_CallCenter_Create-->Create::" + ex.Message); }
            finally { conn.Close(); }
            return result;
        }
    }
}
