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
    /// 유저 정보
    /// </summary>
    public class User : BasicDBModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("birthday")]
        public DateTime BirthDay { get; set; }
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
        [JsonProperty("session_id")]
        public int SessionId { get; set; }
        [JsonProperty("session_name")]
        public string SessionName { get; set; }
        [JsonProperty("remain_session")]
        public int RemainSession { get; set; }
        [JsonProperty("remain_service")]
        public int RemainService { get; set; }
        [JsonProperty("trainer_id")]
        public int TrainerId { get; set; }
        [JsonProperty("trainer_name")]
        public string TrainerName { get; set; }
        [JsonProperty("memo")]
        public string Memo { get; set; }


        [JsonProperty("locker_no")]
        public int LockerNo { get; set; }

        public override string GetQueryParam(eDBQueryType type, bool isFirst = false)
        {
            return type == eDBQueryType.INSERT
                ? $"('{Name}','{BirthDay.ToString(TimeUtil.TIME_FORMAT_1)}','{PhoneNumber}',{SessionId},'{SessionName}',{RemainSession},{RemainService},{TrainerId},'{TrainerName}','{Memo}')"
                : isFirst 
                ? $"SELECT '{Id}' as id, '{Name}' as name, '{BirthDay.ToString(TimeUtil.TIME_FORMAT_1)}' as birthday, '{PhoneNumber}' as phone_number, {SessionId} as session_id, '{SessionName}' as session_name, " +
                $"{RemainSession} as remain_session, {RemainService} as remain_service, {TrainerId} as trainer_id, '{TrainerName}' as trainer_name, '{Memo}' as memo "
                : $"UNION ALL SELECT '{Id}','{Name}','{BirthDay.ToString(TimeUtil.TIME_FORMAT_1)}','{PhoneNumber}',{SessionId},'{SessionName}',{RemainSession},{RemainService},{TrainerId},'{TrainerName}','{Memo}' ";
        }

        public override void Update(object data)
        {
            Name = ((User)data).Name;
            BirthDay = ((User)data).BirthDay;
            PhoneNumber = ((User)data).PhoneNumber;
            SessionId = ((User)data).SessionId;
            SessionName = ((User)data).SessionName;
            RemainSession = ((User)data).RemainSession;
            RemainService = ((User)data).RemainService;
            TrainerId = ((User)data).TrainerId;
            TrainerName = ((User)data).TrainerName;
            Memo = ((User)data).Memo;
        }

        public string GetBirthString()
        {
            return $"{Name} ({BirthDay.ToString("MM/dd")})";
        }
    }
}
