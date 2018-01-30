using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace apiTest
{
    public class baseClient
    {
        public static string Client(string action, string url)
        {
            try
            {
                using (var wc = new WebClient { Encoding = Encoding.UTF8 })
                {
                    string baseUrl = "http://portal.miksystem.com/orgchart/rest.aspx?action={action}";

                    wc.Headers.Add(HttpRequestHeader.Cookie, ".SmartPortalAuthentication=80DA89DF9ECD31F6D56C4A45B86D70BA3DC278E93BB664EFACB909D23AD9672CF23B13948E5F8871254970C4C50053C2223254240BF43228C0CFB75FB29149C69EDAFF3D155691AA3C3F93E7703133B78ED76039");

                    baseUrl = baseUrl.Replace("{action}", action);
                    baseUrl += url;

                    return wc.DownloadString(baseUrl);
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }
    }
}
