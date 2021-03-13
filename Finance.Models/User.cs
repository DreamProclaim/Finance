using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Models
{
    public class User:DataBase
    {
        /// <summary>
        /// 用户名称
        /// </summary>
        public string UserName { set; get; }
        /// <summary>
        /// 用户账号
        /// </summary>
        public string UserNumber { set; get; }
        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { set; get; }
        /// <summary>
        /// 头像路径
        /// </summary>
        public string PiturPath { set; get; }
        /// <summary>
        /// 性别
        /// </summary>
        public int Sex { set; get; }
        /// <summary>
        /// 账号状态
        /// </summary>
        public int Status { set; get; }
    }
}
