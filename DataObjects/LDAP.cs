using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class LDAP
    {
        public string samaccountname { get; set; }
        public string title { get; set; }
        public string mail { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public string displayname { get; set; }
        public string userprincipalname { get; set; }
        public string department { get; set; }
        public string mobile { get; set; }
        public string telephonenumber { get; set; }
        public string pager { get; set; }
        public long logoncount { get; set; }
        public long lockouttime { get; set; }
        public int userAccountControl { get; set; }
        public bool enable { get { return !Convert.ToBoolean(userAccountControl & 0x0002); } }

        public class Login
        {
            private string _user;

            public string User { get => _user.ToLower(); set => _user = value.ToLower(); }
            public string Password { get; set; }

            public Login()
            {
                User = "";
                Password = "";
            }

            public Login(string user, string password)
            {
                _user = user;
                Password = password;
            }

            public Login(string user)
            {
                _user = user;
            }

            public bool IsCheck()
            {
                return User != null && Password != "" && User.Length > 0 && Password.Length > 0;
            }
        }

        public class FilterPara
        {
            public string key { get; set; }
            public string value { get; set; }
            public FilterPara(string _key, string _value)
            {
                this.key = _key;
                this.value = _value;
            }
        }
    }
}
