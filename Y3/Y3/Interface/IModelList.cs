using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Y3.Models;
using Y3.Utility.Enums;

namespace Y3.Interface
{
    public interface IModelList
    {
        void ReadData();
        DataTable GetDataTable();
        T GetbyId<T>(int id);
        List<T> GetList<T>();
        void Add<T>(List<T> list);

        void UpdateData<T>(T data, eDBQueryType type);
        void Save<T>(T data, eDBQueryType type);
    }
}
