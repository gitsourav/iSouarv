using Autofac;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using iSourav.DIResolver;
using System.Reflection;

namespace iSourav.Web.Mvc
{
    public class IocConfig
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            // You can register controllers all at once using assembly scanning...
            builder.RegisterControllers(typeof(MvcApplication).Assembly).InstancePerRequest();

            //builder.RegisterType<Test>().As<ITest>().InstancePerRequest();

            builder.RegisterModule(new RegistryModule()
            {
                Param1 = true //pass additional parameters
            });

            //var assemblyContainingRegisteries = typeof(RegistryModule).Assembly;
            //builder.RegisterAssemblyModules(assemblyContainingRegisteries);

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}