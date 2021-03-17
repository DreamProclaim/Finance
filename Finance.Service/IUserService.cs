using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finance.Models;

namespace Finance.Service
{
    public interface IUserService:IBaseService<User>
    {
        int Create(User user);
    }
}
