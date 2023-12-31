using Autofac;
using MyNote.Application.Services;
using MyNote.Domain.Interactor.Accounts;
using MyNote.Domain.Interfaces.Boudaries.Accounts;
using MyNote.Domain.Interfaces.Repositories;
using MyNote.Domain.Interfaces.Services;
using MyNote.Repository.Repositories;

namespace MyNote.API.AutofaModules
{
    public class AccountModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AccountRepository>().As<IAccountRepository>();
            builder.RegisterType<AccountService>().As<IAccountService>();
            builder.RegisterType<CreateAccount>().As<ICreateAccount>();
            base.Load(builder);
        }
    }
}