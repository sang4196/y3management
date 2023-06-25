using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Y3.Utility.Enums;

namespace Y3.Interface
{
    public interface IDBModel
    {
        string GetQueryParam(eDBQueryType type, bool isFirst = false);
        void Update(object data);
    }
}
