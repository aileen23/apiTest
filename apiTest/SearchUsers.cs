using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiTest
{
    public class SearchUsers
    {
        /// <summary>
        /// 엔트리 타입 0: 부서, 1: 그룹, 2:사용자
        /// </summary>
        public int EntryType { get; set; }
        /// <summary>
        /// 사용자 아이디
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// 사용자 사번
        /// </summary>
        public string EmpID { get; set; }

        /// <summary>
        /// 회사코드
        /// </summary>
        public string CompanyCode { get; set; }
        
        /// <summary>
        /// 회사이름
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// 자회사코드 (있을경우)
        /// </summary>
        public string ChildCompanyCode { get; set; }

        /// <summary>
        /// 자회사이름 (있을경우)
        /// </summary>
        public string ChildCompanyName { get; set; }

        /// <summary>
        /// 부서코드
        /// </summary>
        public string DeptCode { get; set; }

        /// <summary>
        /// 부서이름
        /// </summary>
        public string DeptName { get; set; }

        /// <summary>
        /// 그룹코드
        /// </summary>
        public string GroupCode { get; set; }

        /// <summary>
        /// 그룹이름
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 사용자이름
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// AD DisplayName
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 이메일주소
        /// </summary>
        public string EmailAddress { get; set; }
        
        /// <summary>
        /// SIP
        /// </summary>
        public string SIPUri { get; set; }
        
        /// <summary>
        /// 직위코드
        /// </summary>
        public string TitleCode { get; set; }

        /// <summary>
        /// 직위이름
        /// </summary>
        public string TitleName { get; set; }

        /// <summary>
        /// 직급코드
        /// </summary>
        public string RankCode { get; set; }

        /// <summary>
        /// 직급이름
        /// </summary>
        public string RankName { get; set; }

        /// <summary>
        /// 직책코드
        /// </summary>
        public string JobCode { get; set; }

        /// <summary>
        /// 직책이름
        /// </summary>
        public string JobName { get; set; }

        /// <summary>
        /// 직무코드
        /// </summary>
        public string DutyCode { get; set; }

        /// <summary>
        /// 직무이름
        /// </summary>
        public string DutyName { get; set; }

        /// <summary>
        /// 근무지역 코드
        /// </summary>
        public string LocationCode { get; set; }

        /// <summary>
        /// 근무지역 이름
        /// </summary>
        public string LocationName { get; set; }

        /// <summary>
        /// 모바일 연락처
        /// </summary>
        public string MobileTel { get; set; }

        /// <summary>
        /// 회사 연락처
        /// </summary>
        public string OfficeTel { get; set; }

        /// <summary>
        /// 회사 연락처 2
        /// </summary>
        public string OfficeTelExt { get; set; }
    }
}
