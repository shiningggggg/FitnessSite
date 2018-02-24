using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.DalFactory
{
    /// <summary>
    /// 通过DBSession创建DAL层对象,通过此工厂实例DbSession对象，解耦并保证对象唯一
    /// </summary>
    public class DBSessionFactory
    {
        public static IDBSession CreateCurrentDbSession()
        {
            //CallContext:提供与执行代码路径一起传送的属性集
            IDBSession dbSession = (IDBSession)CallContext.GetData("dbSession");
            if (dbSession == null)
            {
                dbSession = new DBSession();
                CallContext.SetData("dbSession", dbSession);
            }
            return dbSession;
        }
        ///<summary>
        ///如果说一个对象保证全局唯一，使用单例模式，如果使用的对象必须线程内唯一，使用数据槽：CallContext
        ///</summary>
    }
}
