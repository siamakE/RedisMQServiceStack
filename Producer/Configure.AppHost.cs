using Funq;
using ServiceStack;
using ServiceStack.Messaging.Redis;
using ServiceStack.Redis;
using ServiceStack.Messaging;
using Producer;

[assembly: HostingStartup(typeof(AppHost))]

namespace MyApp;

public class AppHost : AppHostBase, IHostingStartup
{
    public void Configure(IWebHostBuilder builder) => builder
        .ConfigureServices(services => {
            services.AddSingleton<Service>();
            
            var mqServer = new RedisMqServer(new RedisManagerPool("localhost:6379"))
            {
                DisablePublishingToOutq = true,
            };
            services.AddSingleton<IMessageService>(mqServer);
        });

    public AppHost() : base("MyApp", typeof(MyServices).Assembly) {}

    public override void Configure(Container container)
    {
        SetConfig(new HostConfig {
            UseSameSiteCookies = true,
        });
    }
}
