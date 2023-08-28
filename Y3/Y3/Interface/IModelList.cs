using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Y3.Models;
using Y3.Models.DB;
using Y3.Utility.Enums;

namespace Y3.Interface
{
    public interface IModelList
    {
        void ReadData();
        DataTable GetDataTable();
        BasicDBModel GetbyId<BasicDBModel>(int id);
        List<BasicDBModel> GetList<BasicDBModel>();
        void Add<BasicDBModel>(List<BasicDBModel> list);

        void UpdateData<BasicDBModel>(BasicDBModel data, eDBQueryType type);
        void Save<BasicDBModel>(BasicDBModel data, eDBQueryType type);
    }
}
