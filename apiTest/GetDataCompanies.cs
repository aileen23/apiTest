using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiTest
{
    /// <summary>
    /// GetCompanies의 반환되는 JSON DATA
    /// </summary>
    public class GetDataCompanies
    {
        public List<Companies> Items { get; } = new List<Companies>();
    }
}
