using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiTest
{
    public class UserSetting
    {
        public string UserID { get; set; }
        public string DisplayName { get; set; }
        public string ExternalDisplayName { get; set; }

        public string CompanyCode { get; set; }
        public string ChildCompanyCode { get; set; }
        public string DeptCode { get; set; }
        public string EmailAddress { get; set; }
        public bool IsMultiLang { get; set; }
        public bool IsKorean { get; set; }
        public bool IsEnglish { get; set; }

        public bool IsChiness { get; set; }

    }
}
