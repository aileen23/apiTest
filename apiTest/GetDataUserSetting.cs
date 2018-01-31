using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiTest
{   
    /// <summary>
    /// GetUserSetting의 반환되는 JSON DATA
    /// </summary>
    public class GetDataUserSetting
    {
        /// <summary>
        /// 유저정보
        /// </summary>
        public List<UserSetting> Setting { get; } = new List<UserSetting>();

        /// <summary>
        /// 유저의 회사정보
        /// </summary>
        public List<GetDataCompanies> Companies { get; } = new List<GetDataCompanies>();
    }
}
