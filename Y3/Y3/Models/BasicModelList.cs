using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Y3.Interface;
using Y3.Utility.Enums;

namespace Y3.Models
{
    public abstract class BasicModelList<T> : IModelList where T : class
    {
        // abstract
        public abstract void Add<T>(List<T> list);
        public abstract T GetbyId<T>(int id);
        public abstract DataTable GetDataTable();
        public abstract List<T> GetList<T>();
        public abstract void ReadData();
        public abstract void Save<T>(T data, eDBQueryType type);
        public abstract void UpdateData<T>(T data, eDBQueryType type);

    }
}
