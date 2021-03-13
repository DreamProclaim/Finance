using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finance.Manager;
using Finance.Service;


namespace Finance.Copment
{
    public abstract partial class BaseCopment<T,M>:IBaseService<T>
        where T:class,new()
        where M:BaseManager<T>,new()
    {
        protected M mange = typeof(M).GetConstructor(Type.EmptyTypes).Invoke(null) as M; //Invoke反射
        /// <summary>
        /// 向数据库中添加数据
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        public int Add(string sql)
        {
            return mange.Add(sql);
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        public int Detele(string sql)
        {
            return mange.Delete(sql);
        }
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        public List<T> Query(string sql)
        {
            return mange.Query(sql);
        }
        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        public int Updata(string sql)
        {
            return mange.Updata(sql);
        }
    }
}
