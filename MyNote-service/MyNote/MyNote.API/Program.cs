using Autofac;
using Autofac.Extensions.DependencyInjection;
using MyNote.API;
using MyNote.API.AutofaModules;

static class Program
{
    static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        var host = Host.CreateDefaultBuilder(args);
        host.ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseStartup<Startup>();
        });
        host.ConfigureContainer<ContainerBuilder>(webBuilder =>
        {
            webBuilder.RegisterModule<UserModule>();
            webBuilder.RegisterModule<AccountModule>();
        });
        host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
        return host;
    }
        
}