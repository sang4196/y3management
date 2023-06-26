using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y3.Models.DB
{
    public class QueryString
    {
        // SELECT
        public string QUERY_SELECT_USER = "SELECT * FROM user WHERE useflag = '1'";
        public string QUERY_SELECT_TRAINER = "SELECT * FROM trainer WHERE useflag = '1'";
        public string QUERY_SELECT_TRAINER_SALES = "SELECT * FROM trainer_sales WHERE useflag = '1'";
        public string QUERY_SELECT_SESSION_PRICE = "SELECT * FROM session_price WHERE useflag = '1'";
        public string QUERY_SELECT_SESSION_TRAINER = "SELECT * FROM session_trainer WHERE useflag = '1'";
        public string QUERY_SELECT_SESSION = "SELECT * FROM session WHERE useflag = '1'";

        // INSERT
        public string QUERY_INSERT_USER = "INSERT INTO user (name, birthday, phone_number, session_id, session_name, remain_session, remain_service, locker_no, memo) VALUES ";
        public string QUERY_INSERT_TRAINER = "INSERT INTO trainer (name, birthday, phone_number, salary, memo) VALUES ";
        public string QUERY_INSERT_TRAINER_SALES = "INSERT INTO trainer_sales (trainer_id, trainer_name, sales_date, sales_price, memo) VALUES ";
        public string QUERY_INSERT_SESSION_PRICE = "INSERT INTO session_price (session_name, price, percentage, deduct, final_price) VALUES ";
        public string QUERY_INSERT_SESSION_TRAINER = "INSERT INTO session_trainer (session_id, session_name, trainer_id, trainer_name, percentage) VALUES ";
        public string QUERY_INSERT_SESSION = "INSERT INTO session (date, trainer_id, trainer_name, user_id, user_name, session_price_id, session_price_name, session_count, session_total_price, is_service) VALUES ";

        // UPDATE
        public string QUERY_UPDATE_USER_1 = "UPDATE user u JOIN(";
        public string QUERY_UPDATE_USER_2 = ") v ON u.id=v.id SET u.name=v.name, u.birthday=v.birthday, u.phone_number=v.phone_number, u.session_id=v.session_id, u.session_name=v.session_name, u.remain_session=v.remain_session, u.remain_service=v.remain_service, u.locker_no=v.locker_no, u.memo=v.memo;";
        public string QUERY_UPDATE_TRAINER_1 = "UPDATE trainer u JOIN(";
        public string QUERY_UPDATE_TRAINER_2 = ") v ON u.id=v.id SET u.name=v.name, u.birthday=v.birthday, u.phone_number=v.phone_number, u.salary=v.salary, u.memo=v.memo;";
        public string QUERY_UPDATE_TRAINER_SALES_1 = "UPDATE trainer_sales u JOIN(";
        public string QUERY_UPDATE_TRAINER_SALES_2 = ") v ON u.id=v.id SET u.trainer_id=v.trainer_id, u.trainer_name=v.trainer_name, u.sales_date=v.sales_date, u.sales_price=v.sales_price, u.memo=v.memo;";
        public string QUERY_UPDATE_SESSION_PRICE_1 = "UPDATE session_price t JOIN(";
        public string QUERY_UPDATE_SESSION_PRICE_2 = ") v ON t.id=v.id SET t.session_name=v.session_name, t.price=v.price, t.percentage=v.percentage, t.deduct=v.deduct, t.final_price=v.final_price;";
        public string QUERY_UPDATE_SESSION_TRAINER_1 = "UPDATE session_trainer t JOIN(";
        public string QUERY_UPDATE_SESSION_TRAINER_2 = ") v ON t.id=v.id SET t.session_id=v.session_id, t.session_name=v.session_name, t.trainer_id=v.trainer_id, t.trainer_name=v.trainer_name, t.percentage=v.percentage;";
        public string QUERY_UPDATE_SESSION_1 = "UPDATE session t JOIN(";
        public string QUERY_UPDATE_SESSION_2 = ") v ON t.id=v.id SET t.date=v.date, t.trainer_id=v.trainer_id, t.trainer_name=v.trainer_name, t.user_id=v.user_id, t.user_name=v.user_name, t.session_price_id=v.session_price_id, t.session_price_name=v.session_price_name, t.session_count=v.session_count, t.session_total_price=v.session_total_price, t.is_service=v.is_service;";

        // DELETE
        public string QUERY_DELETE_USER = "UPDATE user SET useflag = 0 where id='{0}'";
        public string QUERY_DELETE_TRAINER = "UPDATE trainer SET useflag = 0 where id='{0}'";
        public string QUERY_DELETE_TRAINER_SALES = "UPDATE trainer_sales SET useflag = 0 where id='{0}'";
        public string QUERY_DELETE_SESSION_PRICE = "UPDATE session_price SET useflag = 0 where id='{0}'";
        public string QUERY_DELETE_SESSION_TRAINER = "UPDATE session_trainer SET useflag = 0 where id='{0}'";
        public string QUERY_DELETE_SESSION = "UPDATE session SET useflag = 0 where id='{0}'";
    }
}
