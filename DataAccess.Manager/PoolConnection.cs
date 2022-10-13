using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Manager {
    class PoolConnection {
        #region Variables
        public SqlConnection connSQLS;

        private string _ServerName;
        private string _ServerType;
        private string _UserName;
        private string _Password;
        private string _ConnectionString;
        private SqlTransaction _Transaction;
        private ConnectionType _ConnectionType;
        private string _DataBaseName;
        #endregion

        #region Properties
        public string ServerType {
            get { return _ServerType; }
            set { _ServerType = value; }
        }

        public string ServerName {
            get { return _ServerName; }
            set { _ServerName = value; }
        }

        public string UserName {
            get { return _UserName; }
            set { _UserName = value; }
        }

        public string Password {
            get { return _Password; }
            set { _Password = value; }
        }

        public ConnectionType Type {
            get { return _ConnectionType; }
            set { _ConnectionType = value; }
        }

        public SqlTransaction transaction {
            get { return _Transaction; }
            set { _Transaction = value; }
        }

        public string DataBaseName {
            get { return _DataBaseName; }
            set { _DataBaseName = value; }
        }

        #endregion

        #region Builders
        public PoolConnection() {

        }

        public PoolConnection(string connectionString, ConnectionType type) {
            _ConnectionString = connectionString;
            _ConnectionType = type;
        }
        public PoolConnection(SqlTransaction transaction) {
            _Transaction = transaction;
        }
        public PoolConnection(string serverName, string dataBaseName, string userName, string pasword, ConnectionType type) {
            _ServerName = serverName;
            _UserName = userName;
            _Password = pasword;
            _DataBaseName = dataBaseName;
            _ConnectionType = type;

            CreateConnection();
        }
        #endregion

        #region Create Events
        private void CreateConnection() {
            switch (_ConnectionType) {
                case ConnectionType.SQLServer:
                    _ServerType = "MSSQL";
                    break;
            }

            CreateConnectionString();
        }

        private void CreateConnectionString() {
            switch (_ConnectionType) {
                case ConnectionType.SQLServer:
                    _ConnectionString = String.Format(Settings.Default.ConnectionStringSQL, _ServerName, _DataBaseName, _UserName, _Password);
                    break;
            }
        }
        #endregion

        #region Connection Events
        public Boolean OpenConnection() {
            try {
                CloseConnection();
                if (String.IsNullOrEmpty(_ConnectionString)) {
                    CreateConnection();
                }

                switch (_ConnectionType) {
                    case ConnectionType.SQLServer:
                        if (connSQLS == null) {
                            connSQLS = new SqlConnection(_ConnectionString);
                        }

                        connSQLS.Open();
                        break;
                }
            } catch (Exception ex) {
                return false;
            }

            return true;
        }

        public void CloseConnection() {
            switch (_ConnectionType) {
                case ConnectionType.SQLServer:
                    if (connSQLS != null)
                        if (connSQLS.State != System.Data.ConnectionState.Closed)
                            connSQLS.Close();
                    break;
            }
        }
        #endregion
    }
}
