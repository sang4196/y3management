using Newtonsoft.Json;
using Org.BouncyCastle.Asn1.X500;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Y3.Cores.Database;
using Y3.Forms;
using Y3.Forms.Finance;
using Y3.Forms.Session;
using Y3.Forms.Setting;
using Y3.Models;
using Y3.Models.DB;
using Y3.Utility;
using Y3.Utility.Enums;
using static Y3.Enums;
using Formatting = Newtonsoft.Json.Formatting;

namespace Y3
{
    public class Core : Singleton<Core>
    {
        private const string PATH_BASE = "C:\\Y3\\";
        private const string PATH_CONFIG = "Config\\";
        private const string PARAMETER_FILE_QUERY = "query.json";
        private const string PARAMETER_CONFIG_QUERY = "Config.json";

        private QueryString _queryString = new QueryString();
        private Config _Config = new Config();

        // form
        public frmMain _frmMain;
        private frmFinanceMain _frmFinanceMain;
        private frmSessionStats _frmSessionMain;
        private frmSessionRegister _frmSessionRegister;
        private frmSessionSales _frmSessionSales;
        private frmSettingUser _frmSettingUser;
        private frmSettingSession _frmSettingSession;

        // db
        private MariaDB _mariaDB;

        private ModelList _modelList;

        public void InitCore()
        {
            InitFolder();

            InitDB();

            _modelList = new ModelList();

            _frmFinanceMain = new frmFinanceMain();
            _frmSessionMain = new frmSessionStats();
            _frmSessionRegister = new frmSessionRegister();
            _frmSessionSales = new frmSessionSales();
            _frmSettingUser = new frmSettingUser();
            _frmSettingSession = new frmSettingSession();

            _frmMain.ChangeStatusString(_mariaDB.IsConnected());
        }

        private void InitDB()
        {
            _mariaDB = new MariaDB();
        }

        private void InitFolder()
        {
            if (Directory.Exists(PATH_BASE + PATH_CONFIG) == false)
            {
                Directory.CreateDirectory(PATH_BASE + PATH_CONFIG);
            }

            //_queryString = ReadJsonToObject<QueryString>(_queryString, PATH_BASE + PATH_CONFIG + PARAMETER_FILE_QUERY);
            _Config = ReadJsonToObject<Config>(_queryString, PATH_BASE + PATH_CONFIG + PARAMETER_CONFIG_QUERY);
        }
        public decimal CalcTotalPrice(decimal price, decimal per, decimal deduct)
        {
            per /= 100;
            deduct /= 100;

            return (price - (price * deduct)) * per;
        }

        public void CloseProc()
        {
            SaveConfig();
            Application.Exit();
        }

        public void SaveConfig()
        {
            SaveObjectToJson(_Config, PATH_BASE + PATH_CONFIG + PARAMETER_CONFIG_QUERY);
        }

        public string MakePhoneNumber(string number)
        {
            string rtn = number;
            // 01011112222
            rtn = rtn.Insert(3, "-");
            // 010-11112222
            if (rtn.Length > 11) rtn = rtn.Insert(8, "-");
            // 010-1112222
            else rtn = rtn.Insert(7, "-");

            return rtn;
        }

        public string ReversePhoneNumber(string number)
        {
            return number.Replace("-", "");
        }

        public void SaveObjectToJson(object _object, string _fileName)
        {
            string writeText = JsonConvert.SerializeObject(_object, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

            File.WriteAllText(_fileName, writeText);
        }

        public T ReadJsonToObject<T>(object _object, string _fileName)
        {
            T ob = default(T);
            string readText;
            if (File.Exists(_fileName))
            {
                readText = File.ReadAllText(_fileName);
                ob = JsonConvert.DeserializeObject<T>(readText, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            }
            return ob;
        }

        public List<T> DataTableToObject<T>(DataTable dt)
        {
            string serializeddt = JsonConvert.SerializeObject(dt, Formatting.Indented);
            return JsonConvert.DeserializeObject<List<T>>(serializeddt, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public DataTable ObjectToDataTable<T>(List<T> items)
        {
            var tb = new DataTable(typeof(T).Name);

            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var prop in props)
            {
                tb.Columns.Add(prop.Name, prop.PropertyType);
            }

            foreach (var item in items)
            {
                var values = new object[props.Length];
                for (var i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }

                tb.Rows.Add(values);
            }

            return tb;
        }

        public void TypingOnlyNumber(object sender, KeyPressEventArgs e, bool _IncludePoint, bool _bIncludeMinus)
        {
            bool bValid = false;

            if (char.IsControl(e.KeyChar) == false && char.IsDigit(e.KeyChar) == false)
            {
                if (_IncludePoint == true)
                {
                    if (e.KeyChar == '.')
                    {
                        bValid = true;
                    }
                }

                if (_bIncludeMinus == true)
                {
                    if (e.KeyChar == '-')
                    {
                        bValid = true;
                    }
                }

                if (bValid == false)
                {
                    e.Handled = true;
                }
            }

            if (_IncludePoint == true)
            {
                if (e.KeyChar == '.' && (string.IsNullOrEmpty((sender as TextBox).Text.Trim()) || (sender as TextBox).Text.IndexOf(".") >= 0))
                {
                    e.Handled = true;
                }
            }

            if (_bIncludeMinus == true)
            {
                if (e.KeyChar == '-' && (string.IsNullOrEmpty((sender as TextBox).Text.Trim()) || (sender as TextBox).Text.IndexOf("-") >= 0))
                {
                    e.Handled = true;
                }
            }
        }

        #region grid ui
        public void SetGridCol_Text(DataGridView Grid
                                    , DataGridViewTextBoxColumn col
                                    , string colKey
                                    , string colName
                                    , bool bReadOnly = true
                                    , int iWidth = 100
                                    , bool bVisible = true)
        {
            col.DataPropertyName = colKey;
            col.Name = colKey.ToLower();
            col.HeaderText = colName;

            col.ReadOnly = bReadOnly;
            col.Width = iWidth;
            col.Visible = bVisible;

            Grid.Columns.Add(col);
        }

        public void SetGridCol_CheckBox(DataGridView Grid
                                        , DataGridViewCheckBoxColumn col
                                        , string colKey
                                        , string colName
                                        , bool bReadOnly = true
                                        , int iWidth = 100
                                        , bool bVisible = true)
        {
            col.DataPropertyName = colKey;
            col.Name = colKey.ToLower();
            col.HeaderText = colName;

            col.ReadOnly = bReadOnly;
            col.Width = iWidth;
            col.Visible = bVisible;

            Grid.Columns.Add(col);
        }

        public void SetGridCol_Combo(DataGridView Grid
                                    , DataGridViewComboBoxColumn col
                                    , string colKey
                                    , string colName
                                    , System.Data.DataTable dataSource
                                    , bool bReadOnly = true
                                    , DataGridViewComboBoxDisplayStyle strDisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox
                                    , int iWidth = 100
                                    , bool bVisible = true)
        {
            col.DataPropertyName = colKey;
            col.Name = colKey.ToLower();
            col.HeaderText = colName;

            //datatable
            col.ValueMember = dataSource.Columns[0].ColumnName;
            col.DisplayMember = dataSource.Columns[1].ColumnName;
            col.DataSource = dataSource;

            col.ReadOnly = bReadOnly;
            col.DisplayStyle = strDisplayStyle;
            col.Width = iWidth;
            col.Visible = bVisible;

            col.FlatStyle = FlatStyle.Flat;

            Grid.Columns.Add(col);
        }
        public void setGridCol_Button(DataGridView Grid
                                    , DataGridViewButtonColumn col
                                    , string colKey
                                    , string colName
                                    , bool bReadOnly = true
                                    , int iWidth = 100
                                    , bool bVisible = true)
        {
            col.DataPropertyName = colKey;
            col.Name = colKey.ToLower();
            col.HeaderText = colName;

            col.ReadOnly = bReadOnly;
            col.Width = iWidth;
            col.Visible = bVisible;

            Grid.Columns.Add(col);
        }
        #endregion

        // finance
        public static frmFinanceMain FORM_FINANCE_MAIN { get => _instance._frmFinanceMain; }
        // session
        public static frmSessionStats FORM_SESSION_MAIN { get => _instance._frmSessionMain; }
        public static frmSessionRegister FORM_SESSION_REGISTER { get => _instance._frmSessionRegister; }
        public static frmSessionSales FORM_SESSION_SALES { get => _instance._frmSessionSales; }
        // setting
        public static frmSettingUser FORM_SETTING_USER { get => _instance._frmSettingUser; }
        public static frmSettingSession FORM_SETTING_SESSION { get => _instance._frmSettingSession; }

        // db
        public static MariaDB MARIA { get => _instance._mariaDB; }
        public static QueryString QUERY { get => _instance._queryString; }
        public static ModelList MODELS { get => _instance._modelList; }

        // config
        public static Config CONFIG { get=>_instance._Config; }
    }
}
