using Fitness.IDAL;
using Fitness.Model;
using Fitness.Model.Entities;
using System.Collections.Generic;

namespace Fitness.DAL
{
    public class UsersDal:BaseDal<LoginViewModel>,IUsersDal
    {
        AppModelEntities db = (AppModelEntities)DbContextFactory.CreateCurrentDbContext(); 
        public List<LoginViewModel> GetUsersData(int pageIndex,int pageSize,out int totalCount)
        {
            using (var modelContainer = new AppModelEntities())
            {
                //var list = modelContainer..Where(u => u.IsDeleted == false).ToList();
                //totalCount = list.Count();
                //list = list.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
                //return list;
                totalCount = 0;
                return null;
            }
        }
    }
}
