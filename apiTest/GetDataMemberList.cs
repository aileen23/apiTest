using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiTest
{
    /// <summary>
    /// GetMemberList에서 반환되는 JSON DATA
    /// </summary>
    public class GetDataMemberList
    {
        public List<SearchUsers> dataRoot { get; } = new List<SearchUsers>();
    }
}
