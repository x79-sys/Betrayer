using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace Betrayer
{
    class combo
    {
        public static bool check(string user, string password)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://authserver.mojang.com/authenticate");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{" + "\r\n" + "\"agent\": {" + "\r\n" + "    \"name\": \"Minecraft\"," + "\r\n" + "    \"version\": 1" + "\r\n" + "}," + "\r\n" + "\"username\": \"" + user + "\"," + "\r\n" + "\"password\": \"" + password + "\"" + "\r\n" + "}";
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                var streamReader = new StreamReader(httpResponse.GetResponseStream());
                return true;
            }

            catch
            {
                return false;
            }
        }
    }
}
