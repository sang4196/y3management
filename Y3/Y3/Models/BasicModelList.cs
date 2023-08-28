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
    public abstract class BasicModelList : IModelList
    {
        // abstract
        public abstract void ReadData();
        public abstract BasicDBModel GetbyId<BasicDBModel>(int id);
        public abstract DataTable GetDataTable();
        public abstract List<BasicDBModel> GetList<BasicDBModel>();
        public virtual void Add<BasicDBModel>(List<BasicDBModel> list)
        {
            // 로그남기기
        }
        
        public virtual void Save<BasicDBModel>(BasicDBModel data, eDBQueryType type)
        {
            // 로그남기기
        }
        public virtual void UpdateData<BasicDBModel>(BasicDBModel data, eDBQueryType type)
        {
            // 로그남기기
        }
    }
}
