using Autofac;
using FiapLanchonete.Application;

namespace FiapLanchonete.Infrastructure.Modules
{

    public class ApplicationModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //
            // Register all Types in FiapLanchonete.Application
            //
            builder.RegisterAssemblyTypes(typeof(ApplicationException).Assembly)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
