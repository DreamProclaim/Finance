using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Models
{
    public class Role:DataBase
    {
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { set; get; }
        /// <summary>
        /// 状态
        /// </summary>
        public int Status { set; get; }
    }
}
