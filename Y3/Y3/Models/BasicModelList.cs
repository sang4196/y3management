using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Y3.Interface;
using Y3.Models.DB;
using Y3.Utility.Enums;

namespace Y3.Models
{
    public abstract class BasicModelList<T> : IModelList
    {
        // interface
        public abstract void ReadData();
        public abstract DataTable GetDataTable();



        public abstract T GetById(int id);
        public abstract List<T> GetList();
        public abstract bool Save(T data, eDBQueryType type);
        public virtual void Add(List<T> list)
        {
            // 로그남기기
        }
        
        public virtual void UpdateData(T data, eDBQueryType type = eDBQueryType.INSERT)
        {
            // 로그남기기
        }

        public virtual void UpdateMultiData(List<T> data, eDBQueryType type = eDBQueryType.INSERT)
        {
            // 로그남기기
        }
    }
}
