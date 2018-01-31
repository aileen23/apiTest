using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiTest
{
    /// <summary>
    /// 로그인한 사용자의 정보
    /// </summary>
    public class UserSetting
    {
        /// <summary>
        /// 사용자 아이디
        /// </summary>
        public string UserID { get; set; }
        
        /// <summary>
        /// AD DisplayName
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ExternalDisplayName { get; set; }

        /// <summary>
        /// 회사코드
        /// </summary>
        public string CompanyCode { get; set; }

        /// <summary>
        /// 자회사코드 (있을경우)
        /// </summary>
        public string ChildCompanyCode { get; set; }

        /// <summary>
        /// 부서코드
        /// </summary>
        public string DeptCode { get; set; }

        /// <summary>
        /// 이메일주소
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        ///
        /// </summary>
        public bool IsMultiLang { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsKorean { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsEnglish { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsChiness { get; set; }

    }
}
