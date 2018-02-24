using Autofac;
using Fitness.BLL;
using Fitness.IBLL;

namespace Fitness.BLL
{
    public class ServiceManager
    {
        private static IContainer _serviceContainer { get; set; }
        public static IContainer ServiceContainer
        {
            get
            {
                return _serviceContainer;
            }
        }
        public static void InitContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<InvitationService>().As<IInvitationService>();
            builder.RegisterType<ArticleService>().As<IArticleService>();
            builder.RegisterType<UsersService>().As<IUsersService>();
            _serviceContainer = builder.Build();
        }
    }
}
