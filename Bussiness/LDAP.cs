using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.Protocols;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class LDAP
    {
        public static DataObjects.LDAP Login(DataObjects.LDAP.Login login)
        {
            if (login != null && login.IsCheck() && CheckUser(login))
            {
                return GetUser_anr(login);
            }
            else
            {
                return null;
            }
        }
        private static bool CheckUser(DataObjects.LDAP.Login login)
        {
            bool result = false;
            try
            {
                LdapConnection connection = new LdapConnection("liena.local");
                NetworkCredential credential = new NetworkCredential(login.User, login.Password);
                connection.Credential = credential;
                connection.AuthType = AuthType.Ntlm;
                connection.Bind();
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
        const string lDAP_Username = "kim.nd";
        const string lDAP_Password = "P@ssw0rd1s3rp";

        public static DataObjects.LDAP GetUser_anr(DataObjects.LDAP.Login login)
        {
            return GetUser(new DataObjects.LDAP.FilterPara("anr", login.User));
        }
        public static DataObjects.LDAP GetUser_Pager(string pager)
        {
            return GetUser(new DataObjects.LDAP.FilterPara("pager", pager));
        }

        public static DataObjects.LDAP GetUser_Email(string email)
        {
            return GetUser(new DataObjects.LDAP.FilterPara("mail", email));
        }

        private static DataObjects.LDAP GetUser(params DataObjects.LDAP.FilterPara[] para)
        {
            DataObjects.LDAP lDAP = null;
            using (DirectoryEntry entry = new DirectoryEntry())
            {
                entry.Username = lDAP_Username;
                entry.Password = lDAP_Password;
                DirectorySearcher searcher = new DirectorySearcher(entry);
                searcher.SearchScope = System.DirectoryServices.SearchScope.Subtree;
                string f = "";
                foreach (DataObjects.LDAP.FilterPara p in para)
                {
                    f += String.Format("({0}={1})", p.key, p.value);
                }
                searcher.Filter = "(&(objectClass=user)" + f + ")";
                try
                {
                    SearchResult result = searcher.FindOne();
                    if (result != null)
                    {
                        lDAP = new DataObjects.LDAP();
                        if (result.Properties["samaccountname"].Count > 0)
                            lDAP.samaccountname = result.Properties["samaccountname"][0].ToString();
                        if (result.Properties["title"].Count > 0)
                            lDAP.title = result.Properties["title"][0].ToString();
                        if (result.Properties["mail"].Count > 0)
                            lDAP.mail = result.Properties["mail"][0].ToString();
                        if (result.Properties["description"].Count > 0)
                            lDAP.description = result.Properties["description"][0].ToString();
                        if (result.Properties["name"].Count > 0)
                            lDAP.name = result.Properties["name"][0].ToString();
                        if (result.Properties["displayname"].Count > 0)
                            lDAP.displayname = result.Properties["displayname"][0].ToString();
                        if (result.Properties["userprincipalname"].Count > 0)
                            lDAP.userprincipalname = result.Properties["userprincipalname"][0].ToString();
                        if (result.Properties["department"].Count > 0)
                            lDAP.department = result.Properties["department"][0].ToString();
                        if (result.Properties["mobile"].Count > 0)
                            lDAP.mobile = result.Properties["mobile"][0].ToString();
                        if (result.Properties["telephonenumber"].Count > 0)
                            lDAP.telephonenumber = result.Properties["telephonenumber"][0].ToString();
                        if (result.Properties["pager"].Count > 0)
                            lDAP.pager = result.Properties["pager"][0].ToString();
                        if (result.Properties["logoncount"].Count > 0)
                            lDAP.logoncount = Convert.ToInt64(result.Properties["logoncount"][0]);
                        if (result.Properties["lockouttime"].Count > 0)
                            lDAP.lockouttime = Convert.ToInt64(result.Properties["lockouttime"][0]);
                        if (result.Properties["userAccountControl"].Count > 0)
                            lDAP.userAccountControl = Convert.ToInt32(result.Properties["userAccountControl"][0]);
 
                    }
                }
                catch (System.Runtime.InteropServices.COMException ex)
                {
                    if (ex.ErrorCode == -2147023570)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return lDAP;
        }

        public static void GetGroupAll()
        {
            GetGroup();
        }
        private static DataObjects.LDAP GetGroup(params DataObjects.LDAP.FilterPara[] para)
        {
            DataObjects.LDAP lDAP = null;
            using (DirectoryEntry entry = new DirectoryEntry())
            {
                entry.Username = lDAP_Username;
                entry.Password = lDAP_Password;
                DirectorySearcher searcher = new DirectorySearcher(entry);
                searcher.SearchScope = System.DirectoryServices.SearchScope.Subtree;
                string f = "";
                foreach (DataObjects.LDAP.FilterPara p in para)
                {
                    f += String.Format("({0}={1})", p.key, p.value);
                }
                searcher.Filter = "(&(objectClass=group)" + f + ")";
                try
                {
                    SearchResult result = searcher.FindOne();
                    if (result != null)
                    {
                        lDAP = new DataObjects.LDAP();
                        if (result.Properties["samaccountname"].Count > 0)
                            lDAP.samaccountname = result.Properties["samaccountname"][0].ToString();
                        if (result.Properties["title"].Count > 0)
                            lDAP.title = result.Properties["title"][0].ToString();
                        if (result.Properties["mail"].Count > 0)
                            lDAP.mail = result.Properties["mail"][0].ToString();
                        if (result.Properties["description"].Count > 0)
                            lDAP.description = result.Properties["description"][0].ToString();
                        if (result.Properties["name"].Count > 0)
                            lDAP.name = result.Properties["name"][0].ToString();
                        if (result.Properties["displayname"].Count > 0)
                            lDAP.displayname = result.Properties["displayname"][0].ToString();
                        if (result.Properties["userprincipalname"].Count > 0)
                            lDAP.userprincipalname = result.Properties["userprincipalname"][0].ToString();
                        if (result.Properties["department"].Count > 0)
                            lDAP.department = result.Properties["department"][0].ToString();
                        if (result.Properties["mobile"].Count > 0)
                            lDAP.mobile = result.Properties["mobile"][0].ToString();
                        if (result.Properties["telephonenumber"].Count > 0)
                            lDAP.telephonenumber = result.Properties["telephonenumber"][0].ToString();
                        if (result.Properties["pager"].Count > 0)
                            lDAP.pager = result.Properties["pager"][0].ToString();
                        if (result.Properties["logoncount"].Count > 0)
                            lDAP.logoncount = Convert.ToInt64(result.Properties["logoncount"][0]);
                        if (result.Properties["lockouttime"].Count > 0)
                            lDAP.lockouttime = Convert.ToInt64(result.Properties["lockouttime"][0]);
                        if (result.Properties["userAccountControl"].Count > 0)
                            lDAP.userAccountControl = Convert.ToInt32(result.Properties["userAccountControl"][0]);
                    }
                }
                catch (System.Runtime.InteropServices.COMException ex)
                {
                    if (ex.ErrorCode == -2147023570)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return lDAP;
        }
    }
}
