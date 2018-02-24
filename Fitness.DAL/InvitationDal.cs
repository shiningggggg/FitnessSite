using Fitness.IDAL;
using Fitness.Model;
using Fitness.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.DAL
{
    public class InvitationDal:BaseDal<Invitation>,IInvitationDal
    {
        AppModelEntities db = (AppModelEntities)DbContextFactory.CreateCurrentDbContext();
        public List<Invitation> GetInvitationList()
        {
            return db.Invitation.ToList();
        }
    }
}
