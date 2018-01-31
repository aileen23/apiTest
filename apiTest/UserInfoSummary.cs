using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiTest
{
    /// <summary>
    /// 유저 정보 (단편 정보만 포함한다. 다른 엔티티와 컴포지션 형태로 사용된다.)
    /// </summary>
    public class UserInfoSummary 
    {
        /// <summary>
        /// ID
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 이름
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 디스플레이 네임
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 메일 주소
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 현재 상태
        /// </summary>
        //public UserPresenceType Status { get; set; }

        /// <summary>
        /// 썸네일 URL.
        /// TODO(jhlee): 퀄리티 별로 해야할까?
        /// </summary>
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// 연락처(핸드폰)
        /// </summary>
        public string MobileTel { get; set; }

        /// <summary>
        /// 연락처(사무실)
        /// </summary>
        public string OfficeTel { get; set; }

        /// <summary>
        /// 유저가 속해 있는 팀 ID 리스트 (복수 허용하되, 환경 설정으로 단일팀만 허용 여부를 관리하면 될 듯..)
        /// </summary>
        public List<string> Teams { get; } = new List<string>();

        public override string ToString()
        {
            return $"UserId : {UserId} \n UserName: {UserName} \n EmailAddress : {EmailAddress}";
        }
    }
}
