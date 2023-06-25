using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Y3.Models.DB;

namespace Y3.Cores.Database
{
    public class MariaDB
    {
        private static string _connectionString;
        public MariaDB()
        {
            //_connectionString = "Server=127.0.0.1;Port=3306;Database=y3db;Uid=root;Pwd=!tkd13412153;SslMode=none;OldGuids=true";
            _connectionString = "Server=127.0.0.1;Port=3306;Database=y3db;Uid=root;Pwd=!tkd13412153;OldGuids=true";
        }

        public bool IsConnected()
        {
            using (var conn = new MySqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                }
                catch (Exception)
                {
                    return false;
                }

                if (conn.State == System.Data.ConnectionState.Closed && conn.State == System.Data.ConnectionState.Broken)
                {
                    return false;
                }
                return true;
            }
        }

        public DataTable Get(BasicDBsql get)
        {
            var dt = new DataTable();
            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(get.GetSelectQuery(), conn))
                {
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable GetDataByQueryString(string query)
        {
            var dt = new DataTable();
            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public bool Save(BasicDBsql queueItem, out long id)
        {
            id = 0;
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    using (var trans = conn.BeginTransaction())
                    {
                        using (var cmd = new MySqlCommand(queueItem.GetSaveQuery(), conn, trans))
                        {
                            cmd.ExecuteNonQuery();
                            id = cmd.LastInsertedId;
                        }
                        trans.Commit();
                    }
                }
                return true;
            }
            catch (Exception e)
            {
            }
            return false;
        }

        public bool MultiSave(BasicDBsql queueItem, out long id)
        {
            id = 0;
            int dataCnt = queueItem.GetListCount();
            int start = 0;
            const int limitCnt = 1000;
            int startIdx = 0;
            int queryCnt = limitCnt;
            try
            {
                using (var conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    using (var trans = conn.BeginTransaction())
                    {
                        while (dataCnt > 0)
                        {
                            if (dataCnt > limitCnt)
                            {
                                startIdx = start;
                                start += limitCnt;
                                dataCnt -= limitCnt;
                            }
                            else
                            {
                                startIdx = start;
                                queryCnt = dataCnt;
                                dataCnt -= dataCnt;
                            }
                            using (var cmd = new MySqlCommand(queueItem.GetMultiSaveQuery(startIdx, queryCnt), conn, trans))
                            {
                                cmd.ExecuteNonQuery();
                                id = cmd.LastInsertedId;
                            }
                        }
                        trans.Commit();
                    }
                }

                return true;
            }
            catch (Exception e)
            {
            }
            return false;
        }

        //public static bool Save(BasicDBModel queueItem)
        //{
        //    var sqlLog = string.Empty;
        //    int dataCnt = queueItem.GetSaveListCount();
        //    int start = 0;
        //    const int limitCnt = 1000;
        //    int startIdx = 0;
        //    int queryCnt = limitCnt;
        //    try
        //    {
        //        using (var conn = new MySqlConnection(_connectionString))
        //        {
        //            conn.Open();
        //            using (var trans = conn.BeginTransaction())
        //            {
        //                while (dataCnt > 0)
        //                {
        //                    if (dataCnt > limitCnt)
        //                    {
        //                        startIdx = start;
        //                        start += limitCnt;
        //                        dataCnt -= limitCnt;
        //                    }
        //                    else
        //                    {
        //                        startIdx = start;
        //                        queryCnt = dataCnt;
        //                        dataCnt -= dataCnt;
        //                    }
        //                    using (var cmd = new MySqlCommand(queueItem.GetSaveQuery(startIdx, queryCnt), conn, trans))
        //                    {
        //                        cmd.ExecuteNonQuery();
        //                    }
        //                }
        //                trans.Commit();
        //            }
        //            //queueItem.GetSaveList().ForEach(value => value.AfterFunc());
        //        }

        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //    }
        //    return false;
        //}

    }
}
