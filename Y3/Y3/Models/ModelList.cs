using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Y3.Cores.Database;
using Y3.Models.DB;
using Y3.Utility;
using Y3.Utility.Enums;

namespace Y3.Models
{
    public class ModelList
    {
        public SessionList SESSION { get; }
        public SessionTrainerList SESSION_TRAINER { get; }
        public SessionPriceList SESSION_PRICE { get; }
        public TrainerList TRAINER { get; }
        public UserList USER { get; }
        public TrainerSalesList TRAINER_SALES { get; }
        public LockerList LOCKER { get; }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Session
        public class SessionList : BasicModelList<Session>
        {
            private List<Session> Sessions = new List<Session>();

            public override void ReadData()
            {
                Sessions = Core.Instance.DataTableToObject<Session>(Core.MARIA.Get(new DBSession(eDBQueryType.SELECT)));
            }

            public override DataTable GetDataTable()
            {
                return Core.Instance.ObjectToDataTable<Session>(Sessions);
            }

            public override Session GetById(int id)
            {
                return Sessions.Find(p => p.Id == id);
            }

            public override List<Session> GetList()
            {
                return Sessions;
            }

            public override bool Save(Session data, eDBQueryType type = eDBQueryType.INSERT)
            {
                return true;
            }

            public override void Add(List<Session> list)
            {
                base.Add(list);
                Sessions.AddRange(list);
            }

            public override void UpdateData(Session data, eDBQueryType type = eDBQueryType.INSERT)
            {
                base.UpdateData(data, type);
                var obj = Sessions.FirstOrDefault(p => p.Id == data.Id);
                if (obj != null)
                {
                    if (type == eDBQueryType.DELETE)
                    {
                        Session v = Sessions.Find(p => p.Id == data.Id);
                        Sessions.Remove(v);
                    }
                    else
                    {
                        obj.Update(data);
                    }
                }
                else
                {
                    Sessions.Add(data);
                }
            }

            public override void UpdateMultiData(List<Session> data, eDBQueryType type = eDBQueryType.INSERT)
            {
                base.UpdateMultiData(data, type);
                foreach (Session item in data)
                {
                    var obj = Sessions.FirstOrDefault(p => p.Id == item.Id);
                    if (obj != null)
                    {
                        if (type == eDBQueryType.DELETE)
                        {
                            Session v = Sessions.Find(p => p.Id == item.Id);
                            Sessions.Remove(v);
                        }
                        else
                        {
                            obj.Update(item);
                        }
                    }
                    else
                    {
                        Sessions.Add(item);
                    }
                }

            }

            public DataTable GetDataTable(int trainerNo, DateTime searchDt)
            {
                return Core.Instance.ObjectToDataTable<Session>(GetList(trainerNo, searchDt));
            }

            public List<Session> GetList(int trainerNo, DateTime searchDt)
            {
                return Sessions.Where(p => p.TrainerId == trainerNo && p.Date.ToString(TimeUtil.TIME_FORMAT_6) == searchDt.ToString(TimeUtil.TIME_FORMAT_6)).ToList();
            }

            public List<Session> GetList(int trainerNo, DateTime startDt, DateTime endDt)
            {
                return Sessions.Where(p => p.TrainerId == trainerNo && (p.Date >= startDt && p.Date <= endDt)).ToList();
            }
        }
        #endregion

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region SessionTrainer
        public class SessionTrainerList : BasicModelList<SessionTrainer>
        {
            private List<SessionTrainer> SessionTrainers = new List<SessionTrainer>();

            public override void ReadData()
            {
                SessionTrainers = Core.Instance.DataTableToObject<SessionTrainer>(Core.MARIA.Get(new DBSessionTrainer(eDBQueryType.SELECT)));
            }

            public override DataTable GetDataTable()
            {
                return Core.Instance.ObjectToDataTable<SessionTrainer>(SessionTrainers);
            }

            public override SessionTrainer GetById(int id)
            {
                return SessionTrainers.Find(p => p.Id == id);
            }

            public override List<SessionTrainer> GetList()
            {
                return SessionTrainers;
            }

            public override bool Save(SessionTrainer data, eDBQueryType type = eDBQueryType.INSERT)
            {
                return true;
            }

            public override void Add(List<SessionTrainer> list)
            {
                base.Add(list);
            }

            public override void UpdateData(SessionTrainer data, eDBQueryType type = eDBQueryType.INSERT)
            {
                base.UpdateData(data, type);
                var obj = SessionTrainers.FirstOrDefault(p => p.Id == data.Id);
                if (obj != null)
                {
                    if (type == eDBQueryType.DELETE)
                    {
                        SessionTrainer v = SessionTrainers.Find(p => p.Id == data.Id);
                        SessionTrainers.Remove(v);
                    }
                    else
                    {
                        obj.Update(data);
                    }
                }
                else
                {
                    SessionTrainers.Add(data);
                }
            }

            public override void UpdateMultiData(List<SessionTrainer> data, eDBQueryType type = eDBQueryType.INSERT)
            {
                base.UpdateMultiData(data, type);
            }



            public SessionTrainer GetByTrIdAndSessionID(int TrID, int sessionID)
            {
                return SessionTrainers.Find(p => p.TrainerId == TrID && p.SessionId == sessionID);
            }

            public bool Duplication(int spId, int STTrainerId)
            {
                var var = SessionTrainers.Find(p => p.SessionId == spId && p.TrainerId == STTrainerId);
                return var != null;
            }
        }
        #endregion

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region SessionPrice
        public class SessionPriceList : BasicModelList<SessionPrice>
        {
            private List<SessionPrice> SessionPrice = new List<SessionPrice>();

            public override void ReadData()
            {
                SessionPrice = Core.Instance.DataTableToObject<SessionPrice>(Core.MARIA.Get(new DBSessionPrice(eDBQueryType.SELECT)));
            }

            public override DataTable GetDataTable()
            {
                return Core.Instance.ObjectToDataTable<SessionPrice>(SessionPrice);
            }

            public override SessionPrice GetById(int id)
            {
                return SessionPrice.Find(p => p.Id == id);
            }

            public override List<SessionPrice> GetList()
            {
                return SessionPrice;
            }

            public override bool Save(SessionPrice data, eDBQueryType type = eDBQueryType.INSERT)
            {
                return true;
            }

            public override void Add(List<SessionPrice> list)
            {
                base.Add(list);
            }

            public override void UpdateData(SessionPrice data, eDBQueryType type = eDBQueryType.INSERT)
            {
                base.UpdateData(data, type);
                var obj = SessionPrice.FirstOrDefault(p => p.Id == data.Id);
                if (obj != null)
                {
                    if (type == eDBQueryType.DELETE)
                    {
                        SessionPrice v = SessionPrice.Find(p => p.Id == data.Id);
                        SessionPrice.Remove(v);
                    }
                    else
                    {
                        obj.Update(data);
                    }
                }
                else
                {
                    SessionPrice.Add(data);
                }
            }

            public override void UpdateMultiData(List<SessionPrice> data, eDBQueryType type = eDBQueryType.INSERT)
            {
                base.UpdateMultiData(data, type);
            }



            public bool Duplication(string spName)
            {
                var var = SessionPrice.Find(p => p.SessionName == spName);
                return var != null;
            }

            public DataTable GetCombo()
            {
                DataTable dt = Core.Instance.ObjectToDataTable<SessionPrice>(SessionPrice);
                DataTable rtn = dt.Clone();
                DataRow empty = rtn.NewRow();
                empty["Id"] = 0;
                empty["SessionName"] = "선택";
                rtn.Rows.Add(empty);
                rtn.Merge(dt);
                return rtn;
            }
        }
        #endregion

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Trainer
        public class TrainerList : BasicModelList<Trainer>
        {
            private List<Trainer> Trainers = new List<Trainer>();

            public override void ReadData()
            {
                Trainers = Core.Instance.DataTableToObject<Trainer>(Core.MARIA.Get(new DBTrainer(eDBQueryType.SELECT)));
            }

            public override DataTable GetDataTable()
            {
                ReadData();
                return Core.Instance.ObjectToDataTable<Trainer>(Trainers);
            }

            public override Trainer GetById(int id)
            {
                return Trainers.Find(p => p.Id == id);
            }

            public override List<Trainer> GetList()
            {
                return Trainers;
            }

            public override bool Save(Trainer data, eDBQueryType type = eDBQueryType.INSERT)
            {
                return true;
            }

            public override void Add(List<Trainer> list)
            {
                base.Add(list);
            }

            public override void UpdateData(Trainer data, eDBQueryType type = eDBQueryType.INSERT)
            {
                base.UpdateData(data, type);
                var obj = Trainers.FirstOrDefault(p => p.Id == data.Id);
                if (obj != null)
                {
                    if (type == eDBQueryType.DELETE)
                    {
                        Trainer v = Trainers.Find(p => p.Id == data.Id);
                        Trainers.Remove(v);
                    }
                    else
                    {
                        obj.Update(data);
                    }
                }
                else
                {
                    Trainers.Add(data);
                }
            }

            public override void UpdateMultiData(List<Trainer> data, eDBQueryType type = eDBQueryType.INSERT)
            {
                base.UpdateMultiData(data, type);
            }



            public DataTable GetCombo()
            {
                DataTable dt = Core.Instance.ObjectToDataTable<Trainer>(Trainers);
                DataTable rtn = dt.Clone();
                DataRow empty = rtn.NewRow();
                empty["Id"] = 0;
                empty["Name"] = "선택";
                rtn.Rows.Add(empty);
                rtn.Merge(dt);
                return rtn;
            }

            public List<Trainer> GetMonthBirthTrainer()
            {
                return Trainers.Where(p => p.BirthDay.Month == DateTime.Now.Month && p.BirthDay.Year > 1900).ToList();
            }

        }
        #endregion

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region User
        public class UserList : BasicModelList<User>
        {
            private List<User> Users = new List<User>();

            public override void ReadData()
            {
                Users = Core.Instance.DataTableToObject<User>(Core.MARIA.Get(new DBUser(eDBQueryType.SELECT)));
            }

            public override DataTable GetDataTable()
            {
                ReadData();
                return Core.Instance.ObjectToDataTable<User>(Users);
            }

            public override User GetById(int id)
            {
                return Users.Find(p => p.Id == id);
            }

            public override List<User> GetList()
            {
                return Users;
            }

            public override bool Save(User data, eDBQueryType type = eDBQueryType.INSERT)
            {
                DBUser save = new DBUser(data, type);
                if (!Core.MARIA.Save(save, out long outId))
                {
                    MessageBox.Show("유저 정보 저장 실패.\n관리자에게 문의하세요.", "저장 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }

            public override void Add(List<User> list)
            {
                base.Add(list);
                Users.AddRange(list);
            }

            public override void UpdateData(User data, eDBQueryType type = eDBQueryType.INSERT)
            {
                base.UpdateData(data, type);
                var obj = Users.FirstOrDefault(p => p.Id == data.Id);
                if (obj != null)
                {
                    if (type == eDBQueryType.DELETE)
                    {
                        User v = Users.Find(p => p.Id == data.Id);
                        Users.Remove(v);
                    }
                    else
                    {
                        obj.Update(data);
                    }
                }
                else
                {
                    Users.Add(data);
                }
            }

            public override void UpdateMultiData(List<User> data, eDBQueryType type = eDBQueryType.INSERT)
            {
                base.UpdateMultiData(data, type);
            }


            public DataTable GetUsersHaveSessionDataTableByTrainerId(int trainerId = 0)
            {
                ReadData();
                if (trainerId != 0)
                    return Core.Instance.ObjectToDataTable<User>(Users.Where(p => p.RemainSession + p.RemainService > 0 && p.TrainerId == trainerId).ToList());
                else
                    return Core.Instance.ObjectToDataTable<User>(Users.Where(p => p.RemainSession + p.RemainService > 0).ToList());
            }

            public void MinusUserSessionCount(int userId, int count)
            {
                User d = Users.Find(p => p.Id == userId);
                if (d != null)
                {
                    if (d.RemainSession - count < 0)
                    {
                        count -= d.RemainSession;
                        d.RemainSession = 0;
                        d.RemainService -= count;
                    }
                    else
                    {
                        d.RemainSession -= count;
                    }
                    Save(d, eDBQueryType.UPDATE);
                }
            }

            public List<User> GetMonthBirthUser()
            {
                return Users.Where(p => p.BirthDay.Month == DateTime.Now.Month && p.BirthDay.Year > 1900).ToList();
            }
        }
        #endregion

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region TrainerSales
        public class TrainerSalesList : BasicModelList<TrainerSales>
        {
            private List<TrainerSales> TrainerSales = new List<TrainerSales>();

            public override void ReadData()
            {
                TrainerSales = Core.Instance.DataTableToObject<TrainerSales>(Core.MARIA.Get(new DBTrainerSales(eDBQueryType.SELECT)));
            }

            public override DataTable GetDataTable()
            {
                return Core.Instance.ObjectToDataTable<TrainerSales>(TrainerSales);
            }

            public override TrainerSales GetById(int id)
            {
                return TrainerSales.Find(p => p.Id == id);
            }

            public override List<TrainerSales> GetList()
            {
                return TrainerSales;
            }

            public override bool Save(TrainerSales data, eDBQueryType type = eDBQueryType.INSERT)
            {
                return true;
            }

            public override void Add(List<TrainerSales> list)
            {
                base.Add(list);
            }

            public override void UpdateData(TrainerSales data, eDBQueryType type = eDBQueryType.INSERT)
            {
                base.UpdateData(data, type);
                var obj = TrainerSales.FirstOrDefault(p => p.Id == data.Id);
                if (obj != null)
                {
                    if (type == eDBQueryType.DELETE)
                    {
                        TrainerSales v = TrainerSales.Find(p => p.Id == data.Id);
                        TrainerSales.Remove(v);
                    }
                    else
                    {
                        obj.Update(data);
                    }
                }
                else
                {
                    TrainerSales.Add(data);
                }
            }

            public override void UpdateMultiData(List<TrainerSales> data, eDBQueryType type = eDBQueryType.INSERT)
            {
                base.UpdateMultiData(data, type);
            }


            public DataTable GetDataTable(int trainerNo, DateTime searchDt)
            {
                return Core.Instance.ObjectToDataTable<TrainerSales>(GetList(trainerNo, searchDt));
            }

            public List<TrainerSales> GetList(int trainerNo, DateTime searchDt)
            {
                return TrainerSales.Where(p => p.TrainerId == trainerNo && p.SalesDate.ToString(TimeUtil.TIME_FORMAT_6) == searchDt.ToString(TimeUtil.TIME_FORMAT_6)).ToList();
            }

            public List<TrainerSales> GetList(int trainerNo, DateTime startDt, DateTime endDt)
            {
                return TrainerSales.Where(p => p.TrainerId == trainerNo && (p.SalesDate >= startDt && p.SalesDate <= endDt)).ToList();
            }
        }
        #endregion

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Locker
        public class LockerList : BasicModelList<Locker>
        {
            private List<Locker> Lockers = new List<Locker>();

            public override void ReadData()
            {
                Lockers = Core.Instance.DataTableToObject<Locker>(Core.MARIA.Get(new DBLocker(eDBQueryType.SELECT)));
            }

            public override DataTable GetDataTable()
            {
                return Core.Instance.ObjectToDataTable<Locker>(Lockers);
            }

            public override Locker GetById(int id)
            {
                return Lockers.Find(p => p.Id == id);
            }

            public override List<Locker> GetList()
            {
                return Lockers;
            }

            public override bool Save(Locker data, eDBQueryType type = eDBQueryType.INSERT)
            {
                DBLocker d = new DBLocker(data, type);

                if (Core.MARIA.Save(d, out long outId))
                {
                    data.Id = (int)outId == 0 ? data.Id : (int)outId;
                    UpdateData(data, type);
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public override void Add(List<Locker> list)
            {
                base.Add(list);
                Lockers.AddRange(list);
            }

            public override void UpdateData(Locker data, eDBQueryType type = eDBQueryType.INSERT)
            {
                base.UpdateData(data, type);
            }

            public override void UpdateMultiData(List<Locker> data, eDBQueryType type = eDBQueryType.INSERT)
            {
                base.UpdateMultiData(data, type);
            }


            public Locker GetByNo(int no)
            {
                return Lockers.Find(p => p.LockerNo == no);
            }

            public Locker GetByOwnerId(eUserType type, int id)
            {
                return Lockers.Find(p => p.OwnerType == (int)type && p.OwnerId == id);
            }
        }
        #endregion

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public ModelList()
        {
            ReadData();
        }

        public void ReadData()
        {
            SESSION.ReadData();
            SESSION_TRAINER.ReadData();
            SESSION_PRICE.ReadData();
            TRAINER.ReadData();
            USER.ReadData();
            TRAINER_SALES.ReadData();
            LOCKER.ReadData();
        }

        public decimal GetSessionTrainerTotalPrice(int SPNo, int TRNo)
        {
            var sp = SESSION_PRICE.GetList().Find(p => p.Id == SPNo);
            var st = SESSION_TRAINER.GetList().Find(p => p.TrainerId == TRNo && p.SessionId == SPNo);

            if (sp == null) return 0;
            if (st == null) return sp.FinalPrice;

            return (sp.Price - (sp.Price * (sp.Deduct / 100))) * (st.Percentage / 100);
        }
    }
}
