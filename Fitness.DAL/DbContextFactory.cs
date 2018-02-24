using Fitness.Model;
using System.Data.Entity;
using System.Runtime.Remoting.Messaging;

namespace Fitness.DAL
{
    public class DbContextFactory
    {   
        public static DbContext CreateCurrentDbContext()
        {
            DbContext db = (DbContext)CallContext.GetData("db");
            if (db == null)
            {
                db = new AppModelEntities();
                CallContext.SetData("db", db);
            }
            return db;
        }
    }
}
