using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class CallCenter
    {
        public static int Create(string phone, string extension, string callid, int duration, string status, string recordingfile)
        {
            return DataAccess.CallCenter.Create(phone, extension, callid, duration, status, recordingfile);
        }
    }
}
