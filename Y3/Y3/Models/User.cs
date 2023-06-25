using MySqlX.XDevAPI.Relational;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Y3.Models.DB;
using Y3.Utility;
using Y3.Utility.Enums;

namespace Y3.Models
{
    /// <summary>
    /// 유저 정보
    /// </summary>
    public class User : BasicDBModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("birthday")]
        public DateTime BirthDay { get; set; }
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
        [JsonProperty("session")]
        public string Session { get; set; }
        [JsonProperty("memo")]
        public string Memo { get; set; }

        public override string GetQueryParam(eDBQueryType type, bool isFirst = false)
        {
            return type == eDBQueryType.INSERT
                ? $"('{Name}','{BirthDay.ToString(TimeUtil.TIME_FORMAT_1)}','{PhoneNumber}','{Session}','{Memo}')"
                : isFirst 
                ? $"SELECT '{Id}' as id, '{Name}' as name, '{BirthDay.ToString(TimeUtil.TIME_FORMAT_1)}' as birthday, '{PhoneNumber}' as phone_number, '{Session}' as session, '{Memo}' as memo "
                : $"UNION ALL SELECT '{Id}','{Name}','{BirthDay.ToString(TimeUtil.TIME_FORMAT_1)}','{PhoneNumber}','{Session}','{Memo}' ";
        }

        public override void Update(object data)
        {
            Name = ((User)data).Name;
            BirthDay = ((User)data).BirthDay;
            PhoneNumber = ((User)data).PhoneNumber;
            Session = ((User)data).Session;
            Memo = ((User)data).Memo;
        }

        public string GetBirthString()
        {
            return $"{Name} ({BirthDay.ToString("MM/dd")})";
        }
    }
}
