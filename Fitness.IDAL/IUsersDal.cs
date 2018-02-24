using Fitness.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.IDAL
{
    public interface IUsersDal:IBaseDAL<LoginViewModel>
    {
        List<LoginViewModel> GetUsersData(int pageIndex, int pageSize, out int totalCount);
    }
}
