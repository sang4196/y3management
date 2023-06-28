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
    /// 트레이너 정보
    /// </summary>
    public class Trainer : BasicDBModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("birthday")]
        public DateTime BirthDay { get; set; }
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
        [JsonProperty("salary")]
        public int Salary { get; set; }
        [JsonProperty("memo")]
        public string Memo { get; set; }


        [JsonProperty("locker_no")]
        public int LockerNo { get; set; }

        public override string GetQueryParam(eDBQueryType type, bool isFirst = false)
        {
            return type == eDBQueryType.INSERT
                ? $"('{Name}','{BirthDay.ToString(TimeUtil.TIME_FORMAT_1)}','{PhoneNumber}',{Salary},'{Memo}')"
                : isFirst
                ? $"SELECT '{Id}' as id, '{Name}' as name, '{BirthDay.ToString(TimeUtil.TIME_FORMAT_1)}' as birthday, '{PhoneNumber}' as phone_number, {Salary} as salary, '{Memo}' as memo "
                : $"UNION ALL SELECT '{Id}','{Name}','{BirthDay.ToString(TimeUtil.TIME_FORMAT_1)}','{PhoneNumber}',{Salary},'{Memo}' ";
        }

        public override void Update(object data)
        {
            Name = ((Trainer)data).Name;
            BirthDay = ((Trainer)data).BirthDay;
            PhoneNumber = ((Trainer)data).PhoneNumber;
            Salary = ((Trainer)data).Salary;
            Memo = ((Trainer)data).Memo;
        }

        public string GetBirthString()
        {
            return $"{Name} ({BirthDay.ToString("MM/dd")})";
        }
    }
}
