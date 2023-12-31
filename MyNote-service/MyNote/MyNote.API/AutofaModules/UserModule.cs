using Autofac;
using MyNote.Application.Services;
using MyNote.Domain.Interactors.Users;
using MyNote.Domain.Interfaces.Boudaries.Users;
using MyNote.Domain.Interfaces.Repositories;
using MyNote.Domain.Interfaces.Services;
using MyNote.Repository.Repositories;

namespace MyNote.API.AutofaModules
{
    public class UserModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();
            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
            builder.RegisterType<CreateUser>().As<ICreateUser>().InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
