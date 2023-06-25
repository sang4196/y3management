using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Y3.Interface;
using Y3.Utility.Enums;

namespace Y3.Models.DB
{
    public abstract class BasicDBsql : IDBsql
    {
        protected readonly eDBQueryType _queryType;
        protected readonly List<IDBModel> _saveList;
        protected readonly IDBModel _save;

        protected BasicDBsql(List<IDBModel> list, eDBQueryType queryType)
        {
            _saveList = list;
            _queryType = queryType;
        }

        protected BasicDBsql(IDBModel save, eDBQueryType queryType)
        {
            _save = save;
            _queryType = queryType;
        }

        protected BasicDBsql(eDBQueryType queryType)
        {
            _queryType = queryType;
        }

        public int GetListCount()
        {
            return _saveList.Count;
        }

        // 멀티는 되도록 쓰지말자..
        // id값 찾아오는데 불필요한 io가 소모...
        public abstract string GetMultiSaveQuery(int startIdx, int count);

        public abstract string GetSaveQuery();

        public abstract string GetSelectQuery();
    }
}
