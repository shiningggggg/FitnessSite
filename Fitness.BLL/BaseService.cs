using Fitness.DalFactory;
using Fitness.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.BLL
{
    public abstract class BaseService<T> where T : class, new()
    {
        public IDBSession DbSession
        {
            get { return DBSessionFactory.CreateCurrentDbSession(); }
        }
        public IBaseDAL<T> CurrentDal { get; set; }
        public abstract void SetCurrentDal();
        public BaseService()
        {
            SetCurrentDal();
        }
    }
}
