using Fitness.DalFactory;
using Fitness.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.IBLL
{
    /// <summary>
    /// 为类提供接口，是编程规范问题。
    /// 接口化的编程，为的就是将实现封装起来
    /// 调用者只关心接口，不关心实现
    /// 也就是"高内聚，低耦合"的思想
    /// </summary>
    public interface IBaseService<T> where T:class,new()
    {
        IDBSession DbSession { get; }

        IBaseDAL<T> CurrentDal { get; set; }

    }
}
