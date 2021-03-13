using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Service
{
    public interface IBaseService<T>where T:class,new()
    {
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        int Add(string sql);
        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        int Updata(string sql);
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        int Detele(string sql);
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        List<T> Query(string sql);
    }
}
