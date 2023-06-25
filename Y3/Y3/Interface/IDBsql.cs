using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y3.Interface
{
    internal interface IDBsql
    {
        string GetMultiSaveQuery(int startIdx, int count);
        string GetSaveQuery();
        string GetSelectQuery();
    }
}
