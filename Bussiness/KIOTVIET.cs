using System;
using System.Collections.Generic;
using System.Configuration;
using System.DirectoryServices;
using System.DirectoryServices.Protocols;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Bussiness
{
    public class KIOTVIET
    {
        public string ID { get; set; }
        public string Secret { get; set; }
        public string Retailer = ConfigurationManager.AppSettings["retailer"];
        public string Authorization = "Bearer ";

        public KIOTVIET()
        {
            ID = ConfigurationManager.AppSettings["client_id"];
            Secret = ConfigurationManager.AppSettings["client_secret"];
        }

        public KIOTVIET(string client_id, string client_secret)
        {
            ID = client_id;
            Secret = client_secret;
        }
         
        public HttpResponseMessage Delete(string url)
        {
            HttpResponseMessage item = null;
            try
            {
                System.Net.WebRequest request = System.Net.WebRequest.Create(url);
                request.Credentials = GetCredential(url);
                request.Method = "DELETE";
                request.ContentType = "application/json; charset=utf-8";
                System.Net.WebResponse response = request.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                Stream dataStream = response.GetResponseStream();
                System.IO.StreamReader reader = new System.IO.StreamReader(dataStream);
                string result = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();
                item = Newtonsoft.Json.JsonConvert.DeserializeObject<HttpResponseMessage>(result);
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("API-->KIOTVIET-->Delete::" + ex.Message);
                item = new HttpResponseMessage(HttpStatusCode.Forbidden);
            }
            return item;
        }

        private CredentialCache GetCredential(string url)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;
            CredentialCache credentialCache = new CredentialCache();
            credentialCache.Add(new System.Uri(url), "Basic", new NetworkCredential(ID, Secret));
            return credentialCache;
        }

        private System.Net.NetworkCredential GetNetworkCredential(string url)
        {
            System.Net.NetworkCredential netCredential = new System.Net.NetworkCredential(ID, Secret);
            return netCredential;
        }

        private string Gettoken()
        {
            var client = new RestClient("https://id.kiotviet.vn/connect/token");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("application/x-www-form-urlencoded", "grant_type=client_credentials&scope=all&client_id=" + ID + "&client_secret=" + Secret, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            dynamic resp = JObject.Parse(response.Content);
            String token = resp.access_token;
            return token;
            //client = new RestClient("https://public.kiotapi.com//branches?format=json&includeRemoveIds=true&orderBy=branchName&orderDirection=desc&pageSize=30&currentItem=0&includeRemoveIds=true");
            //request = new RestRequest(Method.GET);
            //request.AddHeader("Retailer", Retailer);
            //request.AddHeader("authorization", "Bearer " + token);
            //request.AddHeader("cache-control", "no-cache");
            //response = client.Execute(request);
        }

        public T Get<T>(string url) where T : class
        {
            T item = null;
            try
            {
                System.Net.WebRequest request = System.Net.WebRequest.Create(url);
                request.Credentials = GetCredential(url);
                request.Method = "GET";
                request.Headers["Retailer"] = Retailer;
                request.Headers["Authorization"] = Authorization + Gettoken();
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;
                request.ContentType = "application/json; charset=utf-8";
                System.Net.WebResponse response = request.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                Stream dataStream = response.GetResponseStream();
                System.IO.StreamReader reader = new System.IO.StreamReader(dataStream);
                string result = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();
                item = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(result);
                return item;
            }
            catch (Exception ex)
            {
                Utilities.FileLog.WriteFileLog("API-->KIOTVIET-->Get::" + ex.Message);
                item = null;
            }
            return item;
        }

        public IEnumerable<T> GetToList<T>(string url) where T : class
        {
            IEnumerable<T> lsArray = null;
            try
            {
                System.Net.WebRequest request = System.Net.WebRequest.Create(url);
                request.Credentials = GetCredential(url);
                request.Method = "GET";
                request.Headers["Retailer"] = Retailer ;
                request.Headers["Authorization"] = Authorization + Gettoken();
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;
                request.ContentType = "application/json; charset=utf-8";
                System.Net.WebResponse response = request.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                Stream dataStream = response.GetResponseStream();
                System.IO.StreamReader reader = new System.IO.StreamReader(dataStream);
                string result = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();
                lsArray = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<T>>(result);
            }
            catch (Exception ex)
            {
                Utilities.FileLog.WriteFileLog("API-->KIOTVIET-->GetToList::" + ex.Message);
                lsArray = null;
            }
            return lsArray;
        }

        public string POST<T>(T obj, string url) where T : class
        {
            string postData = "";
            string result = "";
            try
            {
                postData = Newtonsoft.Json.JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented, new Newtonsoft.Json.JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                });
                //Utilities.FileLog.WriteFileLog("API-->KIOTVIET-->POST::Data" + Environment.NewLine + postData);
                System.Net.WebRequest request = System.Net.WebRequest.Create(url);
                byte[] credentialBuffer = new UTF8Encoding().GetBytes(ID + ":" + Secret);
                request.Headers["Retailer"] = Retailer ;
                request.Headers["Authorization"] = Authorization + Gettoken();
                request.PreAuthenticate = true;
                request.Method = "POST";

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
                ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(delegate { return true; });
                byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/json; charset=utf-8";
                request.ContentLength = byteArray.Length;

                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                System.Net.WebResponse response = request.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                dataStream = response.GetResponseStream();
                System.IO.StreamReader reader = new System.IO.StreamReader(dataStream);
                result = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                Utilities.FileLog.WriteFileLog("API-->KIOTVIET-->POST::Data" + Environment.NewLine + postData);
                Utilities.FileLog.WriteFileLog("API-->KIOTVIET-->POST::" + ex.Message);
            }
            return result;
        }

        public T Deserialize<T>(string result) where T : class
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(result);
        }

        public HttpResponseMessage PUT<T>(T obj, string url) where T : class
        {
            string postData = "";
            HttpResponseMessage item = null;
            try
            {
                postData = Newtonsoft.Json.JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented, new Newtonsoft.Json.JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                });
                System.Net.WebRequest request = System.Net.WebRequest.Create(url);
                byte[] credentialBuffer = new UTF8Encoding().GetBytes(ID + ":" + Secret);
                //request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(credentialBuffer);
                request.Headers["Retailer"] = Retailer;
                request.Headers["Authorization"] = Authorization + Gettoken();
                //request.Credentials = GetCredential(url);
                request.PreAuthenticate = true;
                request.Method = "PUT";
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;
                byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/json; charset=utf-8";
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                System.Net.WebResponse response = request.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                dataStream = response.GetResponseStream();
                System.IO.StreamReader reader = new System.IO.StreamReader(dataStream);
                string result = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();
                item = Newtonsoft.Json.JsonConvert.DeserializeObject<HttpResponseMessage>(result);
            }
            catch (Exception ex)
            {
                Utilities.FileLog.WriteFileLog("API-->KIOTVIET-->PUT::" + ex.Message);
                item = new HttpResponseMessage(HttpStatusCode.Forbidden);
            }
            return item;
        }

        public string GetString(string url)
        {
            string item = "";
            try
            {
                System.Net.WebRequest request = System.Net.WebRequest.Create(url);
                request.Credentials = GetCredential(url);
                request.Method = "GET";
                request.Headers["Retailer"] = Retailer;
                request.Headers["Authorization"] = Authorization + Gettoken();
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;
                request.ContentType = "application/json; charset=utf-8";
                System.Net.WebResponse response = request.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                Stream dataStream = response.GetResponseStream();
                System.IO.StreamReader reader = new System.IO.StreamReader(dataStream);
                string result = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();
                return result;
            }
            catch (Exception ex)
            {
                Utilities.FileLog.WriteFileLog("API-->KIOTVIET-->GetString::" + ex.Message);
                item = null;
            }
            return item;
        }

        public string WebRequestGet(string url)
        {
            WebRequest request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();

            reader.Close();
            response.Close();
            return responseFromServer;
        }

        public T WebRequestGet<T>(string url) where T : class
        {
            try
            {
                WebRequest request = WebRequest.Create(url);
                request.Credentials = CredentialCache.DefaultCredentials;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;
                WebResponse response = request.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                reader.Close();
                response.Close();
                T item = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(responseFromServer);
                return item;
            }
            catch (Exception ex)
            {
                Utilities.FileLog.WriteFileLog("API-->KIOTVIET-->WebRequestGet::" + ex.Message);
                return null;
            }
        }

        public string WebRequestPOST(string url, string postData)
        {
            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";
            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(postData);
            request.Headers["Retailer"] = Retailer;
            request.Headers["Authorization"] = Authorization + Gettoken();
            request.ContentType = "application/xml";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            //Utilities.FileLog.WriteFileLog(responseFromServer);
            reader.Close();
            response.Close();
            return responseFromServer;
        }
    }
}
