using Autofac;
using Autofac.Integration.Mvc;
using Fitness.Infrastructure;
using System.Reflection;
using System.Web.Mvc;

namespace Fitness.WebUi.App_Start
{
    public class IocConfig
    {
        public static void RegisterDependencies()
        {
            // MVC setup documentation here:
            // http://autofac.readthedocs.io/en/latest/integration/mvc.html
            // WCF setup documentation here:
            // http://autofac.readthedocs.io/en/latest/integration/wcf.html
            //
            // First we'll register the MVC/WCF stuff...
            var builder = new ContainerBuilder();

            // MVC - Register your MVC controllers.
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // MVC - OPTIONAL: Register model binders that require DI.
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinderProvider();

            // MVC - OPTIONAL: Register web abstractions like HttpContextBase.
            builder.RegisterModule<AutofacWebTypesModule>();

            // MVC - OPTIONAL: Enable property injection in view pages.
            builder.RegisterSource(new ViewRegistrationSource());

            // MVC - OPTIONAL: Enable property injection into action filters.
            builder.RegisterFilterProvider();

            #region WCF
            // WCF - Register channel factory and channel for service clients.
            //builder
            //  .Register(c => new ChannelFactory<IService>("BasicHttpBinding_IService"))
            //  .SingleInstance();
            //builder
            //  .Register(c => c.Resolve<ChannelFactory<IService>>().CreateChannel())
            //  .As<IService>()
            //  .UseWcfSafeRelease(); 
            #endregion

            // Register application dependencies.
            //builder.RegisterType<ViewDependency>().As<IViewDependency>();
            //builder.RegisterType<FilterDependency>().As<IFilterDependency>();
            Assembly[] assemblies = { Assembly.Load("Fitness.IBLL ") };
            builder.RegisterAssemblyTypes(assemblies).Where(type => typeof(IDependency).IsAssignableFrom(type) && !type.IsAbstract).AsImplementedInterfaces().InstancePerLifetimeScope();//保证对象生命周期基于请求
            // MVC - Set the dependency resolver to be Autofac.
            var container = builder.Build();
            Fitness.Infrastructure.FitnessContainer.Instance = container;
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}