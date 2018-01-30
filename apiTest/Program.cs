using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace apiTest
{
    public class Program : baseClient
    {

        
        static void Main(string[] args)
        {

            //var result = GetCompanies("mik", "ko");
            //var result = GetDeptTree("mik", "D1990000", "ko","1");

            var result = GetUserSetting("ko");

            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }

        /// <summary>
        /// 회사정보를 가져온다.
        /// </summary>
        public static Company GetCompanies(string companyCode, string langCode)
        {
            var url = $"&companyCode={companyCode}&langCode={langCode}";
            var result = Client("GetCompanies", url);

            Company com = new Company();
            JObject obj = JObject.Parse(result);

            com = JsonConvert.DeserializeObject<Company>(obj["Items"].FirstOrDefault().ToString());
               
            return com;
        }

        /// <summary>
        /// 부서정보를 가져온다
        /// </summary>
        public static string GetDepts (string companyCode, string parentDeptCode, string langCode)
        {
            var url = $"&companyCode={companyCode}&parentDeptCode={parentDeptCode}&langCode={langCode}"; 

            return Client("GetDepts", url);
        }

        /// <summary>
        /// 부서정보를 트리형식으로 가져온다. (?)
        /// </summary>
        public static Dept GetDeptTree (string companyCode, string deptCode, string langCode, string onlyUser)
        {
            var url = $"&companyCode={companyCode}&deptCode={deptCode}&onlyUser={onlyUser}&langCode={langCode}";
            var result = Client("GetDeptTree", url);

            Dept dept = new Dept();
            JObject obj = JObject.Parse(result);

            dept = JsonConvert.DeserializeObject<Dept>(obj["Items"].FirstOrDefault().ToString());


            return dept;
        }

        /// <summary>
        /// 로그인한 유저의 정보
        /// </summary>
        public static UserSetting GetUserSetting(string langCode)
        {
            var url = "&langCode=" + langCode;
            var result = Client("GetUserSetting", url);

            var user = new UserSetting();
            JObject obj = JObject.Parse(result);
            user = JsonConvert.DeserializeObject<UserSetting>(obj["Settings"].ToString());

            return user;
        }
       
        /// <summary>
        /// 유저를 검색한다.
        /// </summary>
        public static string GetSearchUser (string companyCode, string keyword , string langCode, string limit, string page)
        {
            var url = "&companyCode=" + companyCode + "&keyword="+ keyword + "&limit=" + limit + "&page="+ page + "&langCode=" + langCode;

            return Client("GetSearchUser", url);
        }
        
        /// <summary>
        /// 부서를 검색한다.
        /// </summary>
        public static string GetSearchDept(string companyCode, string keyword, string langCode)
        {
            var url = "&companyCode=" + companyCode + "&keyword=" + keyword + " &langCode=" + langCode;

            return Client("GetSearchUser", url);
        }

        public static string getMemberList(string mode, string keyword, string query, string langCode, string autoCompleteCount)
        {
            var url ="&mode=" + mode + "&keyword=" + keyword + "&query=" + query + "&autoCompleteCount=" + autoCompleteCount+ "&langCode=" + langCode;

            return Client("GetSearchUser", url);
        }
    }
}
