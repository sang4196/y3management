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
    /// 세션종류
    /// </summary>
    public class SessionPrice : BasicDBModel
    {
        /// <summary>
        /// 세션이름
        /// </summary>
        [JsonProperty("session_name")]
        public string SessionName { get; set; }
        /// <summary>
        /// 세션 가격
        /// </summary>
        [JsonProperty("price")]
        public decimal Price{ get; set; }
        /// <summary>
        /// 트레이너에게 지급될 기본 퍼센테이지
        /// </summary>
        [JsonProperty("percentage")]
        public decimal Percentage { get; set; }
        /// <summary>
        /// 세금으로 인한 공제퍼센트
        /// </summary>
        [JsonProperty("deduct")]
        public decimal Deduct { get; set; }
        [JsonProperty("final_price")]
        public decimal FinalPrice { get; set; }

        public override string GetQueryParam(eDBQueryType type, bool isFirst = false)
        {
            return type == eDBQueryType.INSERT
            ? $"('{SessionName}',{Price},{Percentage},{Deduct},{FinalPrice})"
            : isFirst
            ? $"SELECT '{Id}' as id, '{SessionName}' as session_name, {Price} as price, {Percentage} as percentage, {Deduct} as deduct, {FinalPrice} as final_price "
            : $"UNION ALL SELECT '{Id}','{SessionName}',{Price},{Percentage},{Deduct},{FinalPrice} ";
        }

        public override void Update(object data)
        {
            SessionName = ((SessionPrice)data).SessionName;
            Price = ((SessionPrice)data).Price;
            Percentage = ((SessionPrice)data).Percentage;
            Deduct = ((SessionPrice)data).Deduct;
            FinalPrice = ((SessionPrice)data).FinalPrice;
        }
    }
}
