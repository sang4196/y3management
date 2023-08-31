using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Y3.Interface;
using Y3.Utility.Enums;

namespace Y3.Models.DB
{
    public abstract class BasicDBModel : IDBModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        public abstract string GetQueryParam(eDBQueryType type, bool isFirst = false);

        public abstract void Update(object data);
    }
}
