using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
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
        private List<User> Users = new List<User>();
        private List<SessionPrice> SessionPrice = new List<SessionPrice>();
        private List<SessionTrainer> SessionTrainers = new List<SessionTrainer>();
        private List<Trainer> Trainers = new List<Trainer>();
        private List<Session> Sessions = new List<Session>();
        private List<TrainerSales> TrainerSales = new List<TrainerSales>();
        private List<Locker> Lockers = new List<Locker>();

        public ModelList()
        {
            ReadData();
        }

        public void ReadData()
        {
            ReadUsers();
            ReadTrainers();
            ReadSessionPrice();
            ReadSessionTrainers();
            ReadSessions();
            ReadTrainerSales();
            ReadLockers();
        }

        #region Session
        private void ReadSessions()
        {
            Sessions = Core.Instance.DataTableToObject<Session>(Core.MARIA.Get(new DBSession(eDBQueryType.SELECT)));
        }

        public DataTable GetSessionsDataTable()
        {
            return Core.Instance.ObjectToDataTable<Session>(Sessions);
        }

        public DataTable GetSessionsDataTable(int trainerNo, DateTime searchDt)
        {
            return Core.Instance.ObjectToDataTable<Session>(GetSessions(trainerNo, searchDt));
        }

        public List<Session> GetSessions(int trainerNo, DateTime searchDt)
        {
            return Sessions.Where(p => p.TrainerId == trainerNo && p.Date.ToString(TimeUtil.TIME_FORMAT_6) == searchDt.ToString(TimeUtil.TIME_FORMAT_6)).ToList();
        }

        public Session GetSessionById(int sessionId)
        {
            return Sessions.Find(p=>p.Id  == sessionId);
        }

        public List<Session> GetSessions(int trainerNo, DateTime startDt, DateTime endDt)
        {
            return Sessions.Where(p => p.TrainerId == trainerNo && (p.Date >= startDt && p.Date <= endDt)).ToList();
        }

        public void AddSessions(List<Session> sessions)
        {
            Sessions.AddRange(sessions);
        }

        public void UpdateSessionData(Session data, eDBQueryType type = eDBQueryType.INSERT)
        {
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

        public void UpdateSessionData(List<Session> data, eDBQueryType type = eDBQueryType.INSERT)
        {
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
        #endregion

        #region SessionTrainer
        private void ReadSessionTrainers()
        {
            SessionTrainers = Core.Instance.DataTableToObject<SessionTrainer>(Core.MARIA.Get(new DBSessionTrainer(eDBQueryType.SELECT)));
        }

        public SessionTrainer GetSessionTrainerByTrIdAndSessionID(int TrID, int sessionID)
        {
            return SessionTrainers.Find(p => p.TrainerId == TrID && p.SessionId == sessionID);
        }

        public DataTable GetSessionTrainersDataTable()
        {
            return Core.Instance.ObjectToDataTable<SessionTrainer>(SessionTrainers);
        }

        public bool SessionTrainerDuplication(int spId, int STTrainerId)
        {
            var var = SessionTrainers.Find(p => p.SessionId == spId && p.TrainerId == STTrainerId);
            return var != null;
        }

        public void UpdateSessionTrainerData(SessionTrainer data, eDBQueryType type = eDBQueryType.INSERT)
        {
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
        #endregion

        #region SessionPrice
        private void ReadSessionPrice()
        {
            SessionPrice = Core.Instance.DataTableToObject<SessionPrice>(Core.MARIA.Get(new DBSessionPrice(eDBQueryType.SELECT)));
        }

        public DataTable GetSessionPriceDataTable()
        {
            return Core.Instance.ObjectToDataTable<SessionPrice>(SessionPrice);
        }

        public bool SessionPriceDuplication(string spName)
        {
            var var = SessionPrice.Find(p => p.SessionName == spName);
            return var != null;
        }

        public List<SessionPrice> GetSessionPrices()
        {
            return SessionPrice;
        }

        public SessionPrice GetSessionPriceById(int id)
        {
            return SessionPrice.Find(p=>p.Id == id);
        }

        public DataTable GetSessionPriceCombo()
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

        public void UpdateSessionPriceData(SessionPrice data, eDBQueryType type = eDBQueryType.INSERT)
        {
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
        #endregion

        #region Trainer
        private void ReadTrainers()
        {
            Trainers = Core.Instance.DataTableToObject<Trainer>(Core.MARIA.Get(new DBTrainer(eDBQueryType.SELECT)));
        }

        public DataTable GetTrainersDataTable()
        {
            ReadTrainers();
            return Core.Instance.ObjectToDataTable<Trainer>(Trainers);
        }

        public Trainer GetTrainerById(int id)
        {
            return Trainers.Find(p=>p.Id == id);
        }

        public List<Trainer> GetTrainers()
        {
            return Trainers;
        }

        public DataTable GetTrainersCombo()
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

        public void UpdateTrainerData(Trainer data, eDBQueryType type = eDBQueryType.INSERT)
        {
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
        #endregion

        #region User
        private void ReadUsers()
        {
            Users = Core.Instance.DataTableToObject<User>(Core.MARIA.Get(new DBUser(eDBQueryType.SELECT)));
        }

        public DataTable GetUsersDataTable()
        {
            ReadUsers();
            return Core.Instance.ObjectToDataTable<User>(Users);
        }

        public DataTable GetUsersHaveSessionDataTableByTrainerId(int trainerId = 0)
        {
            ReadUsers();
            if (trainerId != 0)
                return Core.Instance.ObjectToDataTable<User>(Users.Where(p => p.RemainSession + p.RemainService > 0 && p.TrainerId == trainerId).ToList());
            else
                return Core.Instance.ObjectToDataTable<User>(Users.Where(p => p.RemainSession + p.RemainService > 0).ToList());
        }

        public void AddUsers(List<User> data)
        {
            Users.AddRange(data);
        }

        public User GetUserById(int id)
        {
            return Users.Find(p=>p.Id == id);
        }

        public void SaveUser(User user, eDBQueryType saveType)
        {
            DBUser save = new DBUser(user, saveType);
            if (!Core.MARIA.Save(save, out long outId))
            {
                MessageBox.Show("유저 정보 저장 실패.\n관리자에게 문의하세요.", "저장 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                SaveUser(d, eDBQueryType.UPDATE);
            }
        }

        public void UpdateUserData(User data, eDBQueryType type = eDBQueryType.INSERT)
        {
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

        #endregion

        #region TrainerSales
        private void ReadTrainerSales()
        {
            TrainerSales = Core.Instance.DataTableToObject<TrainerSales>(Core.MARIA.Get(new DBTrainerSales(eDBQueryType.SELECT)));
        }

        public DataTable GetTrainerSalesDataTable()
        {
            return Core.Instance.ObjectToDataTable<TrainerSales>(TrainerSales);
        }

        public DataTable GetTrainerSalesDataTable(int trainerNo, DateTime searchDt)
        {
            return Core.Instance.ObjectToDataTable<TrainerSales>(GetTrainerSales(trainerNo, searchDt));
        }

        public List<TrainerSales> GetTrainerSales()
        {
            return TrainerSales;
        }

        public List<TrainerSales> GetTrainerSales(int trainerNo, DateTime searchDt)
        {
            return TrainerSales.Where(p => p.TrainerId == trainerNo && p.SalesDate.ToString(TimeUtil.TIME_FORMAT_6) == searchDt.ToString(TimeUtil.TIME_FORMAT_6)).ToList();
        }

        public List<TrainerSales> GetTrainerSales(int trainerNo, DateTime startDt, DateTime endDt)
        {
            return TrainerSales.Where(p => p.TrainerId == trainerNo && (p.SalesDate >= startDt && p.SalesDate <= endDt)).ToList();
        }

        public void UpdateTrainerSalesData(TrainerSales data, eDBQueryType type = eDBQueryType.INSERT)
        {
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

        #endregion

        #region SessionTrainer
        private void ReadLockers()
        {
            Lockers = Core.Instance.DataTableToObject<Locker>(Core.MARIA.Get(new DBLocker(eDBQueryType.SELECT)));
        }

        public Locker GetLockerByNo(int no)
        {
            return Lockers.Find(p => p.LockerNo == no);
        }

        public void AddLockers(List<Locker> data)
        {
            Lockers.AddRange(data);
        }
        public Locker GetLockerByOwnerId(eUserType type, int id)
        {
            return Lockers.Find(p => p.OwnerType == (int)type && p.OwnerId == id);
        }

        public List<Locker> GetLockers()
        {
            return Lockers;
        }

        public bool SaveLocker(Locker data, eDBQueryType type)
        {
            DBLocker d = new DBLocker(data, type);

            if (Core.MARIA.Save(d, out long outId))
            {
                data.Id = (int)outId == 0 ? data.Id : (int)outId;
                UpdateLockerData(data, type);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void UpdateLockerData(Locker data, eDBQueryType type = eDBQueryType.INSERT)
        {
            var obj = Lockers.FirstOrDefault(p => p.Id == data.Id);
            if (obj != null)
            {
                if (type == eDBQueryType.DELETE)
                {
                    Locker v = Lockers.Find(p => p.Id == data.Id);
                    Lockers.Remove(v);
                }
                else
                {
                    obj.Update(data);
                }
            }
            else
            {
                Lockers.Add(data);
            }
        }
        #endregion

        public List<User> GetMonthBirthUser()
        {
            return Users.Where(p => p.BirthDay.Month == DateTime.Now.Month && p.BirthDay.Year > 1900).ToList();
        }
        public List<Trainer> GetMonthBirthTrainer()
        {
            return Trainers.Where(p => p.BirthDay.Month == DateTime.Now.Month && p.BirthDay.Year > 1900).ToList();
        }

        public decimal GetSessionTrainerTotalPrice(int SPNo, int TRNo)
        {
            var sp = SessionPrice.Find(p => p.Id == SPNo);
            var st = SessionTrainers.Find(p => p.TrainerId == TRNo && p.SessionId == SPNo);

            if (sp == null) return 0;
            if (st == null) return sp.FinalPrice;

            return (sp.Price - (sp.Price * (sp.Deduct / 100))) * (st.Percentage / 100);
        }
    }
}
