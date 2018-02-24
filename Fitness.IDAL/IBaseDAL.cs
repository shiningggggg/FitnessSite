using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.IDAL
{
    /// <summary>
    /// 为类提供接口，是编程规范的问题
    /// 接口化的编程，为的是将实现封装起来
    /// 调用者只关心接口，不关心实现
    /// 符合"高内聚，低耦合"的思想
    /// </summary>
    public interface IBaseDAL<T> where T:class, new()
    {
        IQueryable<T> LoadEntities(System.Linq.Expressions.Expression<Func<T, bool
             >> whereLambda);
        T AddEntity(T entity);
        bool UpdateEntity(T entity);
        bool DeleteEntity(T entity);
    }
}
