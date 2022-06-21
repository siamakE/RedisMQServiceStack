using ServiceStack;
using ServiceStack.Messaging;
using ServiceStack.Messaging.Redis;
using ServiceStack.Redis;

[assembly: HostingStartup(typeof(MyApp.ConfigureAutoQuery))]

namespace MyApp
{
    public class ConfigureAutoQuery : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder) => builder
            .ConfigureAppHost(appHost => {
                appHost.Plugins.Add(new AutoQueryFeature
                {
                    MaxLimit = 1000,
                    GenerateCrudServices = new GenerateCrudServices
                    {
                        AutoRegister = true,
                        AddDataContractAttributes = false,
                        
                    },
                    OnAfterDeleteAsync = (crudContext) =>
                    {
                        return PublishMessage(appHost, crudContext);
                    },
                    OnAfterCreateAsync = (crudContext) =>
                    {
                        return PublishMessage(appHost, crudContext);
                    }
                });;
            });

        private static Task PublishMessage(ServiceStackHost appHost, CrudContext crudContext)
        {
            appHost.Resolve<Service>().PublishMessage(crudContext.Dto);
            return Task.CompletedTask;
        }
    }
}