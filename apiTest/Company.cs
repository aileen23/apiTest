using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiTest
{
    public class Company
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
        /// 보여지는 회사명
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
        public List<string> ChildCompany { get; set; }

        public override string ToString()
        {
            return "CompanyCode : "+ CompanyCode + "CompanyName : " + CompanyName ;
        }
    }
}
