using Fitness.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.IBLL
{
    public interface IUsersService:IBaseService<LoginViewModel>
    {
        bool LoadUserLogin(string userName, string passWord, out string msg, out LoginViewModel user);
        List<LoginViewModel> GetUsersData(int pageIndex, int pageSize, out int totalCount);
    }
}
