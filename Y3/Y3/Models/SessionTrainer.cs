using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Y3.Models.DB;
using Y3.Utility.Enums;

namespace Y3.Models
{
    /// <summary>
    /// 세션, 트레이너별 지급 별개 퍼센테이지
    /// </summary>
    public class SessionTrainer : BasicDBModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("session_id")]
        public int SessionId { get; set; }
        /// <summary>
        /// 세션이름
        /// </summary>
        [JsonProperty("session_name")]
        public string SessionName { get; set; }
        [JsonProperty("trainer_id")]
        public int TrainerId { get; set; }
        /// <summary>
        /// 트레이너명
        /// </summary>
        [JsonProperty("trainer_name")]
        public string TrainerName { get; set; }
        /// <summary>
        /// 트레이너에게 지급될 기본 퍼센트가 아닌 트레이너별 별개 퍼센트
        /// </summary>
        [JsonProperty("percentage")]
        public decimal Percentage { get; set; }

        public override string GetQueryParam(eDBQueryType type, bool isFirst = false)
        {
            return type == eDBQueryType.INSERT
            ? $"({SessionId},'{SessionName}',{TrainerId},'{TrainerName}',{Percentage})"
            : isFirst
            ? $"SELECT '{Id}' as id, {SessionId} as session_id, '{SessionName}' as session_name, {TrainerId} as trainer_id, '{TrainerName}' as trainer_name, {Percentage} as percentage "
            : $"UNION ALL SELECT {SessionId},'{SessionName}',{TrainerId},'{TrainerName}',{Percentage} ";
        }

        public override void Update(object data)
        {
            SessionId = ((SessionTrainer)data).SessionId;
            SessionName = ((SessionTrainer)data).SessionName;
            TrainerId = ((SessionTrainer)data).TrainerId;
            TrainerName = ((SessionTrainer)data).TrainerName;
            Percentage = ((SessionTrainer)data).Percentage;
        }
    }
}
