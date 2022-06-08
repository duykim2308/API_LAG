using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class FileLog
    {
        public static void WriteFileLog(string message)
        {
            string strLogText = string.Empty;

            string FileName = System.AppDomain.CurrentDomain.BaseDirectory + "\\Log\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            StreamWriter log;

            if (!File.Exists(FileName))
            {
                log = new StreamWriter(FileName);
            }
            else
            {
                log = File.AppendText(FileName);
            }


            strLogText += string.Format("{0:yyyy-MM-dd H:mm:ss}", DateTime.Now) + ":::" + message;
            log.WriteLine(strLogText);
            log.Close();
        }
    }
}
