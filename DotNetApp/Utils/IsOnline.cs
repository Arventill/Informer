using System;
using DotNetApp.Utils.Interfaces;
using System.Net;

namespace DotNetApp.Utils
{
    public class IsOnline : IConnection
    {
        public bool hasInternetConnection()
        {
            var address = new Uri(AppConst.InternetCheckoutString);
            //try
            //{
            //    var request = (HttpWebRequest)WebRequest.Create(address);
            //    request.Timeout = 5000;
            //    request.Credentials = CredentialCache.DefaultCredentials;
            //    var response = (HttpWebResponse)request.GetResponse();

            //    return response.StatusCode == HttpStatusCode.NoContent;
            //}
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead(address))
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
