using Fitness.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.IBLL
{
    public interface IInvitationService:IBaseService<Invitation>
    {
        List<Invitation> GetInvitationList();
    }
}
