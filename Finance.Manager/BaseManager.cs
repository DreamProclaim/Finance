using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SQLite.Linq;
using System.Data.SqlClient;

namespace Finance.Manager
{
    public class BaseManager<T> where T : class, new()
    {
        /// <summary>
        /// 链接数据库并打开
        /// </summary>
        /// <returns></returns>
        public static SQLiteConnection Conn()
        {
            string path = Environment.CurrentDirectory;
            string connStr = @"Data Source=" + @"{0}\Accounting.db;";
            string.Format(connStr, path);
            SQLiteConnection con = new SQLiteConnection(connStr);
            con.Open();
            return con;
        }
        /// <summary>
        /// 查询数据 并返回List类型的对象
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns></returns>
        public List<T> Query(string sql)
        {
            var conns = Conn();
            List<T> sQLite = new SQLiteDataAdapter(sql, conns) as List<T>;
            conns.Close();
            return sQLite;
        }
        /// <summary>
        /// 向数据库插入数据
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        public int Add(string sql)
        {
            var conns = Conn();
            SQLiteCommand sql1 = new SQLiteCommand();
            sql1.CommandText = sql;
            sql1.Connection = conns;
            return sql1.ExecuteNonQuery();
        }
        /// <summary>
        /// 修改数据库中的数据
        /// </summary>
        /// <param name="Sql">SQL语句</param>
        /// <returns></returns>
        public int Updata(string Sql)
        {
            var conns = Conn();
            SQLiteCommand command = new SQLiteCommand();
            command.CommandText = Sql;
            command.Connection = conns;
            return command.ExecuteNonQuery();
        }
        /// <summary>
        /// 删除数据库中的数据
        /// </summary>
        /// <param name="Sql">SQL语句</param>
        /// <returns></returns>
        public int Delete(string Sql)
        {
            var conns = Conn();
            SQLiteCommand command = new SQLiteCommand();
            command.CommandText = Sql;
            command.Connection = conns;
            return command.ExecuteNonQuery();
        }
    }
}
