using K4os.Compression.LZ4.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Y3.Models.DB;
using Y3.Utility;
using Y3.Utility.Enums;

namespace Y3.Models
{
    /// <summary>
    /// 세션진행 정보
    /// </summary>
    public class Session : BasicDBModel, ICloneable
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("trainer_id")]
        public int TrainerId { get; set; }
        [JsonProperty("trainer_name")]
        public string TrainerName { get; set; }
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("user_name")]
        public string UserName { get; set; }
        [JsonProperty("session_price_id")]
        public int SessionPriceId { get; set; }
        [JsonProperty("session_price_name")]
        public string SessionPriceName { get; set; }
        [JsonProperty("session_count")]
        public int SessionCount { get; set; }
        [JsonProperty("session_total_price")]
        public decimal SessionTotalPrice { get; set; }
        [JsonProperty("is_service")]
        public bool IsService { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string GetQueryParam(eDBQueryType type, bool isFirst = false)
        {
            return type == eDBQueryType.INSERT
                ? $"('{Date.ToString(TimeUtil.TIME_FORMAT_1)}',{TrainerId},'{TrainerName}',{UserId},'{UserName}',{SessionPriceId},'{SessionPriceName}',{SessionCount}, {SessionTotalPrice}, {IsService})"
                : isFirst
                ? $"SELECT '{Id}' as id, '{Date.ToString(TimeUtil.TIME_FORMAT_1)}' as date, {TrainerId} as trainer_id, '{TrainerName}' as trainer_name, {UserId} as user_id, '{UserName}' as user_name, " +
                $"{SessionPriceId} as session_price_id, '{SessionPriceName}' as session_price_name, {SessionCount} as session_count, {SessionTotalPrice} as session_total_price, {IsService} as is_service "
                : $"UNION ALL SELECT '{Id}','{Date.ToString(TimeUtil.TIME_FORMAT_1)}',{TrainerId},'{TrainerName}',{UserId},'{UserName}',{SessionPriceId},'{SessionPriceName}',{SessionCount}, {SessionTotalPrice}, {IsService} ";
        }

        public override void Update(object data)
        {
            Date = ((Session)data).Date;
            TrainerId = ((Session)data).TrainerId;
            TrainerName = ((Session)data).TrainerName;
            UserId = ((Session)data).UserId;
            UserName = ((Session)data).UserName;
            SessionPriceId = ((Session)data).SessionPriceId;
            SessionPriceName = ((Session)data).SessionPriceName;
            SessionCount = ((Session)data).SessionCount;
            SessionTotalPrice = ((Session)data).SessionTotalPrice;
            IsService = ((Session)data).IsService;
        }
    }
}
