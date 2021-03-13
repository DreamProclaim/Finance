using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finance.Models;

namespace Finance.Manager
{
    public class UserManager:BaseManager<User>
    {
        public string Create(User user)
        {
            string sql = "insert into " +
                "User(UserName,UserNumber,PassWord,PiturPath,Sex,Status) " +
                "values(" + user.UserName + ","+user.UserNumber+","+user.PassWord+","+user.PiturPath+","+user.Sex+"" +
                ","+user.Status+")";
            var result=Add(sql);
            return "";
        }
    }
}
