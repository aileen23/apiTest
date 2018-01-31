using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiTest
{
    /// <summary>
    /// GetSearchDept의 반환되는 JSON DATA
    /// </summary>
    public class GetDataSearchDepartments // GetDataDepartments 랑 똑같은데 일관성을 위해 놔둬야할지...
    {
        public List<Departments> Items { get; } = new List<Departments>();
    }
}
