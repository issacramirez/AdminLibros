using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Manager {
    public class SqlHelper {
        internal static SqlCommand createCommand(SqlConnection conexion, CommandType commandType, string commandText, SqlParameter[] prm, int timeOut) {
            var comando = new SqlCommand();
            comando.CommandText = commandText;
            comando.CommandType = commandType;
            comando.Connection = conexion;
            comando.CommandTimeout = timeOut;

            if (prm != null) {
                comando.Parameters.AddRange(prm);
            }

            return comando;
        }

        internal static SqlCommand createCommand(SqlConnection conexion, CommandType commandType, string commandText, SqlParameter[] prm) {
            return createCommand(conexion, commandType, commandText, prm, 0);
        }

        #region data set
        public static DataSet ExecuteDataSet(string conexionString, CommandType commandType, string commandText, SqlParameter[] prm) {
            using (var conexion = new SqlConnection(conexionString)) {
                var dt = ExecuteDataSet(conexion, commandType, commandText, prm);
                conexion.Close();
                return dt;
            }
        }

        public static DataSet ExecuteDataSet(SqlConnection conexion, CommandType commandType, string commandText, SqlParameter[] prm) {
            using (var comando = createCommand(conexion, commandType, commandText, prm)) {
                DataSet ds = new DataSet();
                using (var adapter = new SqlDataAdapter(comando)) {
                    adapter.Fill(ds);
                }

                return ds;
            }
        }

        public static DataSet ExecuteDataSet(string conexionString, CommandType commandType, string commandText, SqlParameter[] prm, int timeOut) {
            using (var conexion = new SqlConnection(conexionString)) {
                var dt = ExecuteDataSet(conexion, commandType, commandText, prm, timeOut);
                conexion.Close();
                return dt;
            }
        }

        public static DataSet ExecuteDataSet(SqlConnection conexion, CommandType commandType, string commandText, SqlParameter[] prm, int timeOut) {
            using (var comando = createCommand(conexion, commandType, commandText, prm, timeOut)) {
                DataSet ds = new DataSet();
                using (var adapter = new SqlDataAdapter(comando)) {
                    adapter.Fill(ds);
                }

                return ds;
            }
        }

        public static DataSet ExecuteDataSet(SqlTransaction transaction, CommandType commandType, string commandText, SqlParameter[] prm, int timeOut) {
            using (var comando = createCommand(transaction.Connection, commandType, commandText, prm, timeOut)) {
                comando.Transaction = transaction;

                DataSet ds = new DataSet();
                using (var adapter = new SqlDataAdapter(comando)) {
                    adapter.Fill(ds);
                }

                return ds;
            }
        }
        #endregion

        #region data table
        public static DataTable ExecuteDataTable(string conexionString, CommandType commandType, string commandText, SqlParameter[] prm) {
            using (var conexion = new SqlConnection(conexionString)) {
                var dt = ExecuteDataTable(conexion, commandType, commandText, prm);
                conexion.Close();
                return dt;
            }
        }

        public static DataTable ExecuteDataTable(SqlConnection conexion, CommandType commandType, string commandText, SqlParameter[] prm) {
            using (var comando = createCommand(conexion, commandType, commandText, prm)) {
                DataTable dt = new DataTable();
                using (var adapter = new SqlDataAdapter(comando)) {
                    adapter.Fill(dt);
                }

                return dt;
            }
        }

        public static DataTable ExecuteDataTable(string conexionString, CommandType commandType, string commandText, SqlParameter[] prm, int timeOut) {
            using (var conexion = new SqlConnection(conexionString)) {
                var dt = ExecuteDataTable(conexion, commandType, commandText, prm, timeOut);
                conexion.Close();
                return dt;
            }
        }

        public static DataTable ExecuteDataTable(SqlConnection conexion, CommandType commandType, string commandText, SqlParameter[] prm, int timeOut) {
            using (var comando = createCommand(conexion, commandType, commandText, prm, timeOut)) {
                DataTable dt = new DataTable();
                using (var adapter = new SqlDataAdapter(comando)) {
                    adapter.Fill(dt);
                }

                return dt;
            }
        }
        #endregion

        #region Non query
        public static void ExecuteNonQuery(string conexionString, CommandType commandType, string commandText, SqlParameter[] prm) {
            using (var conexion = new SqlConnection(conexionString)) {
                ExecuteNonQuery(conexion, commandType, commandText, prm);
                conexion.Close();
            }
        }

        public static void ExecuteNonQuery(SqlConnection conexion, CommandType commandType, string commandText, SqlParameter[] prm) {
            using (var comando = createCommand(conexion, commandType, commandText, prm)) {
                if (conexion.State != ConnectionState.Open) {
                    conexion.Open();
                }

                comando.ExecuteNonQuery();
            }
        }

        public static void ExecuteNonQuery(SqlTransaction transaccion, CommandType commandType, string commandText, SqlParameter[] prm) {
            using (var comando = createCommand(transaccion.Connection, commandType, commandText, prm)) {
                comando.Transaction = transaccion;

                comando.ExecuteNonQuery();
            }
        }

        public static void ExecuteNonQuery(string conexionString, CommandType commandType, string commandText, SqlParameter[] prm, int timeOut) {
            using (var conexion = new SqlConnection(conexionString)) {
                ExecuteNonQuery(conexion, commandType, commandText, prm, timeOut);
                conexion.Close();
            }
        }

        public static void ExecuteNonQuery(SqlConnection conexion, CommandType commandType, string commandText, SqlParameter[] prm, int timeOut) {
            using (var comando = createCommand(conexion, commandType, commandText, prm, timeOut)) {
                if (conexion.State != ConnectionState.Open) {
                    conexion.Open();
                }

                comando.ExecuteNonQuery();
            }
        }

        public static void ExecuteNonQuery(SqlTransaction transaccion, CommandType commandType, string commandText, SqlParameter[] prm, int timeOut) {
            using (var comando = createCommand(transaccion.Connection, commandType, commandText, prm, timeOut)) {
                comando.Transaction = transaccion;

                comando.ExecuteNonQuery();
            }
        }
        #endregion

        #region reader
        public static SqlDataReader ExecuteReader(SqlConnection conexion, CommandType commandType, string commandText, SqlParameter[] prm) {
            return ExecuteReader(conexion, commandType, commandText, prm, CommandBehavior.SingleResult | CommandBehavior.SequentialAccess);
        }

        public static SqlDataReader ExecuteReader(SqlConnection conexion, CommandType commandType, string commandText) {
            SqlParameter[] prm = new SqlParameter[0];
            return ExecuteReader(conexion, commandType, commandText, prm, CommandBehavior.SingleResult);
        }

        public static SqlDataReader ExecuteReader(SqlConnection conexion, CommandType commandType, string commandText, SqlParameter[] prm, CommandBehavior behavior) {
            using (var comando = createCommand(conexion, commandType, commandText, prm)) {
                if (conexion.State != ConnectionState.Open) {
                    conexion.Open();
                }

                var reader = comando.ExecuteReader(behavior);
                return reader;
            }
        }

        public static SqlDataReader ExecuteReader(SqlTransaction transaccion, CommandType commandType, string commandText, SqlParameter[] prm) {
            return ExecuteReader(transaccion, commandType, commandText, prm, CommandBehavior.SingleResult | CommandBehavior.SequentialAccess);
        }

        public static SqlDataReader ExecuteReader(SqlTransaction transaccion, CommandType commandType, string commandText, SqlParameter[] prm, CommandBehavior behavior) {
            using (var comando = createCommand(transaccion.Connection, commandType, commandText, prm)) {
                comando.Transaction = transaccion;
                var reader = comando.ExecuteReader(behavior);
                return reader;
            }
        }

        public static SqlDataReader ExecuteReader(SqlConnection conexion, CommandType commandType, string commandText, SqlParameter[] prm, int timeOut) {
            return ExecuteReader(conexion, commandType, commandText, prm, CommandBehavior.SingleResult | CommandBehavior.SequentialAccess, timeOut);
        }

        public static SqlDataReader ExecuteReader(SqlConnection conexion, CommandType commandType, string commandText, SqlParameter[] prm, CommandBehavior behavior, int timeOut) {
            using (var comando = createCommand(conexion, commandType, commandText, prm, timeOut)) {
                if (conexion.State != ConnectionState.Open) {
                    conexion.Open();
                }

                var reader = comando.ExecuteReader(behavior);
                return reader;
            }
        }

        public static SqlDataReader ExecuteReader(SqlTransaction transaccion, CommandType commandType, string commandText, SqlParameter[] prm, int timeOut) {
            return ExecuteReader(transaccion, commandType, commandText, prm, CommandBehavior.SingleResult | CommandBehavior.SequentialAccess, timeOut);
        }

        public static SqlDataReader ExecuteReader(SqlTransaction transaccion, CommandType commandType, string commandText, SqlParameter[] prm, CommandBehavior behavior, int timeOut) {
            using (var comando = createCommand(transaccion.Connection, commandType, commandText, prm, timeOut)) {
                comando.Transaction = transaccion;
                var reader = comando.ExecuteReader(behavior);
                return reader;
            }
        }
        #endregion

        #region Scalar
        public static object ExecuteScalar(string conexionString, CommandType commandType, string commandText, SqlParameter[] prm) {
            using (var conexion = new SqlConnection(conexionString)) {
                var result = ExecuteScalar(conexion, commandType, commandText, prm);
                conexion.Close();
                return result;
            }
        }

        public static object ExecuteScalar(SqlConnection conexion, CommandType commandType, string commandText, SqlParameter[] prm) {
            using (var comando = createCommand(conexion, commandType, commandText, prm)) {
                if (conexion.State != ConnectionState.Open) {
                    conexion.Open();
                }

                var result = comando.ExecuteScalar();
                return result;
            }
        }

        public static object ExecuteScalar(string conexionString, CommandType commandType, string commandText, SqlParameter[] prm, int timeOut) {
            using (var conexion = new SqlConnection(conexionString)) {
                var result = ExecuteScalar(conexion, commandType, commandText, prm, timeOut);
                conexion.Close();
                return result;
            }
        }

        public static object ExecuteScalar(SqlConnection conexion, CommandType commandType, string commandText, SqlParameter[] prm, int timeOut) {
            using (var comando = createCommand(conexion, commandType, commandText, prm, timeOut)) {
                if (conexion.State != ConnectionState.Open) {
                    conexion.Open();
                }

                var result = comando.ExecuteScalar();
                return result;
            }
        }
        public static object ExecuteScalar(SqlTransaction transaccion, CommandType commandType, string commandText, SqlParameter[] prm, int timeOut) {
            using (var comando = createCommand(transaccion.Connection, commandType, commandText, prm, timeOut)) {
                comando.Transaction = transaccion;
                var result = comando.ExecuteScalar();
                return result;
            }

        }
        #endregion
    }
}
