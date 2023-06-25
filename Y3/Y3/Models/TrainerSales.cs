using K4os.Compression.LZ4.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
    /// 트레이너별 매출
    /// </summary>
    public class TrainerSales : BasicDBModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("trainer_id")]
        public int TrainerId { get; set; }
        [JsonProperty("trainer_name")]
        public string TrainerName { get; set; }
        [JsonProperty("sales_date")]
        public DateTime SalesDate { get; set; }
        [JsonProperty("sales_price")]
        public int SalesPrice { get; set; }
        [JsonProperty("memo")]
        public string Memo { get; set; }

        public override string GetQueryParam(eDBQueryType type, bool isFirst = false)
        {
            return type == eDBQueryType.INSERT
            ? $"({TrainerId},'{TrainerName}','{SalesDate.ToString(TimeUtil.TIME_FORMAT_1)}',{SalesPrice},'{Memo}')"
            : isFirst
            ? $"SELECT '{Id}' as id, {TrainerId} as trainer_id, '{TrainerName}' as trainer_name, '{SalesDate.ToString(TimeUtil.TIME_FORMAT_1)}' as sales_date, {SalesPrice} as sales_price, '{Memo}' as memo "
            : $"UNION ALL SELECT '{Id}',{TrainerId},'{TrainerName}','{SalesDate.ToString(TimeUtil.TIME_FORMAT_1)}',{SalesPrice},'{Memo}' ";
        }

        public override void Update(object data)
        {
            TrainerId = ((TrainerSales)data).TrainerId;
            TrainerName = ((TrainerSales)data).TrainerName;
            SalesDate = ((TrainerSales)data).SalesDate;
            SalesPrice = ((TrainerSales)data).SalesPrice;
            Memo = ((TrainerSales)data).Memo;
        }
    }
}
