using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiTest
{
    /// <summary>
    /// 회사정보
    /// </summary>
    public class Companies 
    {
        /// <summary>
        /// 회사코드
        /// </summary>
        public string CompanyCode { get; set; }

        /// <summary>
        /// 회사이름
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// AD DisplayName
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 본회사가 자회사인지
        /// </summary>
        public bool IsSubsidiary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsOCSFedoration { get; set; }

        /// <summary>
        /// 자회사 소유 여부
        /// </summary>
        public bool HasChildCompany { get; set; }

        /// <summary>
        /// 자회사 정보
        /// </summary>
        public List<object> ChildCompany { get; } = new List<object>();

        public override string ToString()
        {
            return "companycode : " + CompanyCode + "companyname : " + CompanyName;
        }
    }
}