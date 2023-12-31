using Autofac;
using MyNote.Domain.Interfaces.Repositories;
using MyNote.Repository.Repositories;

namespace MyNote.API.AutofaModules
{
    public class CommonModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
