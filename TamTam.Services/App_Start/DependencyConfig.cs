using DryIoc;
using TamTam.Interfaces.Business;
using TamTam.Interfaces.Business.OMDb;
using TamTam.Interfaces.Business.TamTam;
using TamTam.Interfaces.Business.YouTube;
using TamTam.IoCContainer;

namespace TamTam.Services
{
    public class DependencyConfig
    {
        //Container with injected implementation
        public static IContainer Container;

        /// <summary>
        /// Register dependencies on app startup
        /// </summary>
        public static void RegisterDependencies()
        {
            Container = TamTamContainer.Container;
            IoCResolver.IoCResolver.Resolve(TamTamContainer.Container);

            //Resolve interfaces
            Container.Resolve<IMovie>();
            Container.Resolve<IVideo>();
            Container.Resolve<IAggregatedObject>();
        }
    }
}