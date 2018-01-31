using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiTest
{
    /// <summary>
    /// GetSearchUser의 반환되는 JSON DATA
    /// </summary>
    public class GetDataSearchUsers
    {
        /// <summary>
        /// 현재 페이지
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// 총 페이지수
        /// </summary>
        public int TotalPage { get; set; }

        /// <summary>
        /// 총 갯수
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// Owner 회사코드
        /// </summary>
        public string OwnerCompanyCode { get; set; }
        
        /// <summary>
        /// 유저정보
        /// </summary>
        public List<SearchUsers> Items { get; } = new List<SearchUsers>();
    }
}
