using Autofac;
using ISM.Demo.Providers;
using ISM.Demo.Services;

namespace ISM.Demo.Configrations
{
    public static class HostConfigration
    {
        public static IContainer SetContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<DemoProvider>().As<IDemoProvider>();
            builder.RegisterType<DemoService>().AsSelf();

            return builder.Build();
        }
    }
}
