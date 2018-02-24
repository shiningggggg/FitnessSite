using Fitness.DAL;
using Fitness.IBLL;
using Fitness.IDAL;
using Fitness.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Fitness.BLL
{
    public class InvitationService:BaseService<Invitation>, IInvitationService
    {
        public override void SetCurrentDal()
        {
            CurrentDal = this.DbSession.InvitationDal;
        }
        //这里DBSession和BLL层耦合到了一起
        //DBSession dbSession = new DBSession();       
        /// <summary>
        /// 取得主页数据
        /// </summary>
        /// <returns></returns>
        public List<Invitation> GetInvitationList()
        {
            IInvitationDal invitationDal = this.DbSession.InvitationDal;
            return invitationDal.LoadEntities(c => c.IsDeleted == false).ToList();
        }
    }
}
