using DryIoc;
using TamTam.Business.OMDb;
using TamTam.Business.TamTam;
using TamTam.Business.YouTube;
using TamTam.Interfaces.Business.OMDb;
using TamTam.Interfaces.Business.TamTam;
using TamTam.Interfaces.Business.YouTube;
using TamTam.Interfaces.IoCRegister;

namespace TamTam.Business
{
    public class Registry : IIoCRegister
    {
        /// <summary>
        /// It I'll register business class as interface applying Inversion of Control concept
        /// </summary>
        /// <param name="container"></param>
        public void Register(IContainer container)
        {
            container.Unregister<IMovie>();
            container.Unregister<IVideo>();
            container.Unregister<IAggregatedObject>();

            container.Register<IMovie, BMovie>();
            container.Register<IVideo, BVideo>();
            container.Register<IAggregatedObject, BAggregatedObject>();
        }
    }
}