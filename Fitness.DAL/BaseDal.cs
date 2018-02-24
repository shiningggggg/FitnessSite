using System;
using System.Data.Entity;
using System.Linq;

namespace Fitness.DAL
{
    public class BaseDal<T> where T:class,new()
    {
        DbContext db = DbContextFactory.CreateCurrentDbContext();
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public IQueryable<T> LoadEntities(System.Linq.Expressions.Expression<Func<T, bool
            >> whereLambda)
        {
            return db.Set<T>().Where(whereLambda);
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public T AddEntity(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
            return entity;
        }
        public bool UpdateEntity(T entity)
        {
            db.Entry<T>(entity).State = EntityState.Modified;
            db.SaveChanges();
            return true;
        }
        public bool DeleteEntity(T entity)
        {
            db.Entry<T>(entity).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return true;
        }
    }
}
