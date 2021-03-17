using Finance.Manager;
using Finance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Copment
{
    public class UserCompment:BaseCopment<User,UserManager>
    {
        public int Create(User user)
        {
            return 0;
        }
    }
}
