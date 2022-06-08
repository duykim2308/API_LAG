using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Email
    {
        private const int _SMTP_Timeout = 2000000;

        public Email()
        {
            FromUserName = ConfigurationManager.AppSettings["FromUserName"];
            FromAddress = ConfigurationManager.AppSettings["FromAddress"];
            FromPassword = ConfigurationManager.AppSettings["FromPassword"];
            SMTP_Host = ConfigurationManager.AppSettings["SMTP_Host"];
            SMTP_Port = Convert.ToInt32(ConfigurationManager.AppSettings["SMTP_Port"]);
            SMTP_EnableSsl = true;
            SMTP_UseDefaultCredentials = false;
            SMTP_DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            SMTP_Timeout = _SMTP_Timeout;
            ListToAddress = new System.Collections.Generic.List<string>();
            ListToAddressCC = new System.Collections.Generic.List<string>();
            ListToAddressBcc = new System.Collections.Generic.List<string>();
            ListAttachments = new List<string>();
        }

        public Email(string fromUserName, string fromAddress, string fromPassword, string smtp_Host, int smtp_Port)
        {
            FromUserName = fromUserName;
            FromAddress = fromAddress;
            FromPassword = fromPassword;
            SMTP_Host = smtp_Host;
            SMTP_Port = smtp_Port;
            SMTP_EnableSsl = true;
            SMTP_UseDefaultCredentials = false;
            SMTP_DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            SMTP_Timeout = _SMTP_Timeout;
            ListToAddress = new System.Collections.Generic.List<string>();
            ListToAddressCC = new System.Collections.Generic.List<string>();
            ListToAddressBcc = new System.Collections.Generic.List<string>();
            ListAttachments = new List<string>();
        }

        public Email(string fromAddress, string fromPassword, string smtp_Host, int smtp_Port)
        {
            FromUserName = fromAddress;
            FromAddress = fromAddress;
            FromPassword = fromPassword;
            SMTP_Host = smtp_Host;
            SMTP_Port = smtp_Port;
            SMTP_EnableSsl = true;
            SMTP_UseDefaultCredentials = false;
            SMTP_DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            SMTP_Timeout = _SMTP_Timeout;
            ListToAddress = new System.Collections.Generic.List<string>();
            ListToAddressCC = new System.Collections.Generic.List<string>();
            ListToAddressBcc = new System.Collections.Generic.List<string>();
            ListAttachments = new List<string>();
        }

        public string FromUserName { get; set; }
        public string FromAddress { get; set; }
        public string FromPassword { get; set; }
        public System.Net.Mail.SmtpDeliveryMethod SMTP_DeliveryMethod { get; set; }
        public bool SMTP_EnableSsl { get; set; }
        public string SMTP_Host { get; set; }
        public int SMTP_Port { get; set; }
        public int SMTP_Timeout { get; set; }
        public bool SMTP_UseDefaultCredentials { get; set; }
        public System.Collections.Generic.List<string> ListToAddress { get; set; }
        public System.Collections.Generic.List<string> ListToAddressCC { get; set; }
        public System.Collections.Generic.List<string> ListToAddressBcc { get; set; }
        public System.Collections.Generic.List<string> ListAttachments { get; set; }

        public void Send(string subject, string body)
        {
            System.Net.Mail.MailMessage msg = null;
            string toAddress = "";
            if (ListToAddress != null && ListToAddress.Count > 0)
            {
                toAddress = ListToAddress.First();
            }
            if (toAddress != "")
            {
                msg = new System.Net.Mail.MailMessage(FromAddress, toAddress, subject, body);
                if (ListToAddress != null && ListToAddress.Count > 0)
                {
                    msg.To.Clear();
                    foreach (string str in ListToAddress)
                    {
                        msg.To.Add(str);
                    }
                }

                if (ListToAddressCC != null && ListToAddressCC.Count > 0)
                {
                    msg.CC.Clear();
                    foreach (string str in ListToAddressCC)
                        msg.CC.Add(str);
                }

                if (ListToAddressBcc != null && ListToAddressBcc.Count > 0)
                {
                    msg.Bcc.Clear();
                    foreach (string str in ListToAddressBcc)
                        msg.Bcc.Add(str);
                }

                if (ListAttachments != null && ListAttachments.Count > 0)
                {
                    msg.Attachments.Clear();
                    foreach (string str in ListAttachments)
                        msg.Attachments.Add(new System.Net.Mail.Attachment(str));
                }
                msg.IsBodyHtml = true;

                var smtp = new System.Net.Mail.SmtpClient();
                {
                    smtp.Host = SMTP_Host;
                    smtp.Port = SMTP_Port;
                    smtp.EnableSsl = SMTP_EnableSsl;
                    smtp.UseDefaultCredentials = SMTP_UseDefaultCredentials;
                    smtp.DeliveryMethod = SMTP_DeliveryMethod;
                    smtp.Credentials = new System.Net.NetworkCredential(FromUserName, FromPassword);
                    smtp.Timeout = SMTP_Timeout;
                }
                DateTime fd = DateTime.Now;
                smtp.Send(msg);
                FileLog.WriteFileLog("ITAutoSendMail.Core-->Email-->GetData-->" + String.Format("Start: {0:dd/MM/yyyy HH:mm:ss.fff} - End {1:dd/MM/yyyy HH:mm:ss.fff}", fd, DateTime.Now));
                smtp.Dispose();
                smtp = null;
            }
        }
    }
}
