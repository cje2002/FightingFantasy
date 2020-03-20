using Castle.Windsor;

namespace FightingFantasy.IoC
{
    internal static class WindsorContainerFactory
    {
        private static readonly IWindsorContainer container;

        static WindsorContainerFactory() {
            container = new WindsorContainer();
            container.Install(new RepositoriesInstaller());
        }

        internal static IWindsorContainer Container => container;
    }
}
