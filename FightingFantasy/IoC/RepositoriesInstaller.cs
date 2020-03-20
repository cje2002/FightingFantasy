using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System.Reflection;

namespace FightingFantasy.IoC
{
    public class RepositoriesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromAssemblyInThisApplication(Assembly.GetExecutingAssembly())
                                    .Where(type => type.Name.Contains("Model"))
                                    .WithService.DefaultInterfaces()
                                    .Configure(c => c.LifeStyle.Is(Castle.Core.LifestyleType.Singleton)));
        }
    }
}
