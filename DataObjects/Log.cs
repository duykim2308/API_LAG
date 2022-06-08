using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class Log
    {
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Function { get; set; }
        public string Error { get; set; }
        public DateTime CreateDate { get; set; }


        public Log()
        {
            Date = DateTime.Now;
            Type = "";
            Function = "";
            Error = "";
            CreateDate = DateTime.Now;
        }

        public Log(System.Data.DataRow row)
        {
            Date = row["Date"].ToString() != "" ? Convert.ToDateTime(row["Date"]) : DateTime.Now;
            Type = row["Type"].ToString();
            Function = row["Function"].ToString();
            Error = row["Error"].ToString();
            CreateDate = row["CreateDate"].ToString() != "" ? Convert.ToDateTime(row["CreateDate"]) : DateTime.Now;
        }
    }
}
