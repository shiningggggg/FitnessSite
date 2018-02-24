using Fitness.IBLL;
using Fitness.IDAL;
using Fitness.Model.Entities;
using System.Collections.Generic;

namespace Fitness.BLL
{
    public class UsersService:BaseService<LoginViewModel>,IUsersService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = this.DbSession.UsersDal;
        }

        public bool LoadUserLogin(string userName, string passWord, out string msg, out LoginViewModel user)
        {
            //user = usersDal.LoadEntities(u => u.Username == userName).FirstOrDefault();
            //if (user != null)
            //{
            //    if (user.Password == passWord)
            //    {
            //        msg = "登录成功";
            //        return true;
            //    }
            //    else
            //    {
            //        msg = "密码错误";
            //        return false;
            //    }
            //}
            //else
            //{
            //    msg = "用户名错误";
            //    return false;
            //}     
            user = null;
            msg = "";     
            return false;     
        }
        public List<LoginViewModel> GetUsersData(int pageIndex, int pageSize,out int totalCount)
        {
            IUsersDal usersDal = this.DbSession.UsersDal;
            return usersDal.GetUsersData(pageIndex, pageSize,out totalCount);
        }
    }
}
