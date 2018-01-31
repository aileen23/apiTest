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

            // var result = GetCompanies("mik", "ko");
            //var result = GetDepts("mik", "D1990000", "ko");
            //var result = GetDeptTree("mik", "D1990000", "ko","Y");
            var result = GetSearchUser("mik", "a", "ko", 10, 1);
            //var result = GetUserSetting("ko");
            Console.WriteLine(result);
            Console.WriteLine("---------------------------------");
            var convert = OrgchartToUser(result);
            Console.WriteLine(convert.ToString());
            Console.ReadLine();


        }

        /// <summary>
        /// 회사정보를 가져온다.
        /// </summary>
        public static GetDataCompanies GetCompanies(string companyCode, string langCode)
        {
            var url = $"&companyCode={companyCode}&langCode={langCode}";
            var result = Client("GetCompanies", url);

            GetDataCompanies data = JsonConvert.DeserializeObject<GetDataCompanies>(result);

            return data;
        }

        /// <summary>
        /// 부서정보를 가져온다
        /// </summary>
        public static GetDataDepartments GetDepts (string companyCode, string parentDeptCode, string langCode)
        {
            var url = $"&companyCode={companyCode}&parentDeptCode={parentDeptCode}&langCode={langCode}";
            var result = Client("GetDepts", url);

            GetDataDepartments data = JsonConvert.DeserializeObject<GetDataDepartments>(result);

            return data;
        }

        /// <summary>
        /// 부서정보를 트리형식으로 가져온다. (?)
        /// </summary>
        public static GetDataDepartments GetDeptTree (string companyCode, string deptCode, string langCode, string onlyUser)
        {
            var url = $"&companyCode={companyCode}&deptCode={deptCode}&langCode={langCode}&onlyUser={onlyUser}";
            var result = Client("GetDeptTree", url);

            GetDataDepartments data = JsonConvert.DeserializeObject<GetDataDepartments>(result);

            return data;
        }

        /// <summary>
        /// 로그인한 유저의 정보
        /// </summary>
        public static GetDataUserSetting GetUserSetting(string langCode)
        {
            var url = $"&langCode={langCode}";
            var result = Client("GetUserSetting", url);
            
            GetDataUserSetting data = JsonConvert.DeserializeObject<GetDataUserSetting>(result);

            return data;
        }
       
        /// <summary>
        /// 유저를 검색한다.
        /// </summary>
        public static GetDataSearchUsers GetSearchUser (string companyCode, string keyword , string langCode, int limit, int page)
        {
            var url = $"&companyCode={ companyCode}&keyword={keyword}&limit={limit}&page={page}&langCode={langCode}";
            var result = Client("GetSearchUser", url);

            GetDataSearchUsers data = JsonConvert.DeserializeObject<GetDataSearchUsers>(result);

            return data;
        }
        
        /// <summary>
        /// 부서를 검색한다.
        /// </summary>
        public static GetDataSearchDepartments GetSearchDept(string companyCode, string keyword, string langCode)
        {
            var url = $"&companyCode={companyCode}&keyword={keyword}&langCode={langCode}";
            var result = Client("GetSearchUser", url);

            GetDataSearchDepartments data = JsonConvert.DeserializeObject<GetDataSearchDepartments>(result);

            return data;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GetDataMemberList getMemberList(string mode, string keyword, string query, string langCode, string autoCompleteCount)
        {
            var url =$"&mode={mode}&keyword={keyword}&query={query}&autoCompleteCount={autoCompleteCount}&langCode={langCode}";
            var result = Client("getMemberList", url);

            GetDataMemberList data = JsonConvert.DeserializeObject<GetDataMemberList>(result);

            return data;
        }


        public static List<UserInfoSummary> OrgchartToUser(GetDataSearchUsers userData)
        {
            List<SearchUsers> userList = userData.Items;
            
            List<UserInfoSummary> userInfo = new List<UserInfoSummary>();

            for(int i = 0 ; i < userList.Count; i++ )
            {
                SearchUsers user  = userList[i];
                UserInfoSummary summary = new UserInfoSummary();
                summary.UserId = user.UserID;
                summary.UserName = user.UserName;
                summary.DisplayName = user.DisplayName;
                summary.EmailAddress = user.EmailAddress;
                summary.MobileTel = user.MobileTel;
                summary.OfficeTel = user.OfficeTel;

                userInfo.Add(summary);
            }
            return userInfo;
        }
    }
}
