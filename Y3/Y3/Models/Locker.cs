using MySqlX.XDevAPI.Relational;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Y3.Models.DB;
using Y3.Utility;
using Y3.Utility.Enums;

namespace Y3.Models
{
    /// <summary>
    /// 락커정보
    /// </summary>
    public class Locker : BasicDBModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("locker_no")]
        public int LockerNo { get; set; }
        [JsonProperty("owner_type")]
        public int OwnerType { get; set; }
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }
        [JsonProperty("owner_name")]
        public string OwnerName { get; set; }
        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }
        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }

        public override string GetQueryParam(eDBQueryType type, bool isFirst = false)
        {
            return type == eDBQueryType.INSERT
                ? $"({LockerNo},{OwnerType},{OwnerId},'{OwnerName}','{StartDate.ToString(TimeUtil.TIME_FORMAT_1)}','{EndDate.ToString(TimeUtil.TIME_FORMAT_1)}')"
                : isFirst
                ? $"SELECT '{Id}' as id, {LockerNo} as locker_no, {OwnerType} as owner_type, {OwnerId} as owner_id, '{OwnerName}' as owner_name, '{StartDate.ToString(TimeUtil.TIME_FORMAT_1)}' as start_date, '{EndDate.ToString(TimeUtil.TIME_FORMAT_1)}' as end_date "
                : $"UNION ALL SELECT '{Id}',{LockerNo},{OwnerType},{OwnerId},'{OwnerName}','{StartDate.ToString(TimeUtil.TIME_FORMAT_1)}','{EndDate.ToString(TimeUtil.TIME_FORMAT_1)}' ";
        }

        public override void Update(object data)
        {
            LockerNo = ((Locker)data).LockerNo;
            OwnerType = ((Locker)data).OwnerType;
            OwnerId = ((Locker)data).OwnerId;
            OwnerName = ((Locker)data).OwnerName;
            StartDate = ((Locker)data).StartDate;
            EndDate = ((Locker)data).EndDate;
        }
    }
}
