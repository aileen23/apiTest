using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiTest
{
    /// <summary>
    /// GetDepts, GetDeptTree 의 반환되는 JSON DATA 
    /// </summary>
    public class GetDataDepartments
    {
        public List<Departments> Items { get; } = new List<Departments>();
    }
}
