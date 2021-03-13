using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Models
{
    public class Menu:DataBase
    {
        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MenuName { set; get; }
        /// <summary>
        /// 命名空间
        /// </summary>
        public string Namespaces { set; get; }
        /// <summary>
        /// 类名称
        /// </summary>
        public string ClassName { set; get; }
        /// <summary>
        /// Action名称
        /// </summary>
        public string ActionName { set; get; }
        /// <summary>
        /// 图标路径
        /// </summary>
        public string PicturPath { set; get; }
        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { set; get; }
        /// <summary>
        /// 父级菜单
        /// </summary>
        public int Print { set; get; }
        /// <summary>
        /// 状态
        /// </summary>
        public int Status { set; get; }
    }
}
