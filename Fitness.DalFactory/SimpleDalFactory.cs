using Fitness.DAL;
using Fitness.IDAL;
using System.Configuration;
using System.Reflection;

namespace Fitness.DalFactory
{
    public class SimpleDalFactory
    {
        public static object CreateInstance(string assemblyPath, string fullClassName)
        {
            var assembly = Assembly.Load(assemblyPath);
            return assembly.CreateInstance(fullClassName);
        }
        //通过读取config里面的配置文件来创建
        public static IInvitationDal CreateInvitationDal()
        {
            string classFullName = ConfigurationManager.AppSettings["DalAssembly"] + ".InvitationDal";
            //因为需要创建很多个Dal层的对象，所以，将CreateInstance独立成一个静态方法去使用。
            //var obj = Assembly.Load(ConfigurationManager.AppSettings[""]).CreateInstance(classFullName, true);
            var obj = CreateInstance(ConfigurationManager.AppSettings["DalNameSpace"], classFullName);
            return obj as IInvitationDal;
        }
        public static IArticleDal CreateArticleDal()
        {
            string classFullName = ConfigurationManager.AppSettings["DalAssembly"] + ".ArticleDal";
            var obj = CreateInstance(ConfigurationManager.AppSettings["DalNameSpace"], classFullName);
            return obj as IArticleDal;
        }
        public static IUsersDal CreateUsersDal()
        {
            string classFullName = ConfigurationManager.AppSettings["DalAssembly"] + ".UsersDal";
            var obj = CreateInstance(ConfigurationManager.AppSettings["DalNameSpace"], classFullName);
            return obj as IUsersDal;
        }
    }
}
