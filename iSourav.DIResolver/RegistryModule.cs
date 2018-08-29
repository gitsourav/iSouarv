using Autofac;
using iSourav.Business;
using iSourav.DebugLogger;
using iSourav.Domain.Interfaces;
using iSourav.Domain.Interfaces.Providers;
using iSourav.EmailSender;
using System;
using System.Linq;

namespace iSourav.DIResolver
{
    public class RegistryModule : Module
    {
        public bool Param1 { get; set; }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Test>().As<ITest>().InstancePerRequest();

            builder.RegisterType<Debug>().As<ILoggerProvider>().InstancePerRequest();

            builder.RegisterType<EmailService>().As<INotificationProvider>().InstancePerRequest();

            var asmbly = AppDomain.CurrentDomain.GetAssemblies()
                .Where(a => a.FullName.StartsWith("iSourav")).ToArray();
            builder.RegisterAssemblyTypes(asmbly)
                   .Where(t => t.Name.EndsWith("Repository"))
                   .AsImplementedInterfaces();


            //if (Param1)
            //    builder.RegisterType<SaneDriver>().As<IDriver>();
            //else
            //    builder.RegisterType<CrazyDriver>().As<IDriver>();
        }
    }
}
