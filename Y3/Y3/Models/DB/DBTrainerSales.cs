using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Y3.Interface;
using Y3.Models.DB;
using Y3.Utility.Enums;

namespace Y3.Models.DB
{
    /// <summary>
    /// 트레이너별 매출 저장 클래스
    /// </summary>
    public class DBTrainerSales : BasicDBsql
    {
        public DBTrainerSales(List<TrainerSales> saveList, eDBQueryType type)
            : base(new List<IDBModel>(saveList), type)
        {
            
        }

        public DBTrainerSales(TrainerSales save, eDBQueryType type)
            : base(save, type)
        {

        }

        public DBTrainerSales(eDBQueryType type)
            : base(type)
        {

        }

        public override string GetMultiSaveQuery(int startIdx, int count)
        {
            List<IDBModel> save = new List<IDBModel>();
            save = _saveList.GetRange(startIdx, count);

            var paramsQuery = string.Empty;
            switch (_queryType)
            {
                case eDBQueryType.INSERT:
                    paramsQuery = string.Join(",", save.Select(data => ((TrainerSales)data).GetQueryParam(_queryType)).ToArray());
                    return $"{Core.QUERY.QUERY_INSERT_TRAINER_SALES} {paramsQuery}";
                case eDBQueryType.UPDATE:
                    for (var index = 0; index < save.Count; index++)
                    {
                        paramsQuery += save[index].GetQueryParam(_queryType, (index == 0));
                    }
                    return $"{Core.QUERY.QUERY_UPDATE_TRAINER_SALES_1} {paramsQuery} {Core.QUERY.QUERY_UPDATE_TRAINER_SALES_2}";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public override string GetSaveQuery()
        {
            var paramsQuery = string.Empty;
            switch (_queryType)
            {
                case eDBQueryType.INSERT:
                    paramsQuery = ((TrainerSales)_save).GetQueryParam(_queryType);
                    return $"{Core.QUERY.QUERY_INSERT_TRAINER_SALES} {paramsQuery}";
                case eDBQueryType.UPDATE:
                    paramsQuery += ((TrainerSales)_save).GetQueryParam(_queryType, true);
                    return $"{Core.QUERY.QUERY_UPDATE_TRAINER_SALES_1} {paramsQuery} {Core.QUERY.QUERY_UPDATE_TRAINER_SALES_2}";
                case eDBQueryType.DELETE:
                    return string.Format(Core.QUERY.QUERY_DELETE_TRAINER_SALES, ((TrainerSales)_save).Id);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public override string GetSelectQuery()
        {
            return Core.QUERY.QUERY_SELECT_TRAINER_SALES;
        }
    }
}