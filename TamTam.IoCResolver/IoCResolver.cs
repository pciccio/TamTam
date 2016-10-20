using System.Collections.Generic;
using System.Linq;
using DryIoc;
using TamTam.Business;
using TamTam.Interfaces.IoCRegister;
using TamTam.IoCContainer;

namespace TamTam.IoCResolver
{
    public static class IoCResolver
    {
        /// <summary>
        /// This method resolve all IoC Business to interface.
        /// In this we are declaring/registering mapping between interfaces and implementations. 
        /// It means that I can register different Interfaces implementations without touching business or other resolution code.
        /// Helps to enforce Open-Closed principle and to improve Testability and Extensibility.
        /// </summary>
        /// <param name="container"></param>
        /// <returns></returns>
        public static IContainer Resolve(IContainer container)
        {
            if (container == null)
                container = TamTamContainer.Container;

            //Add all registers here
            //Could have database and others implementations...
            var registers = new List<IIoCRegister> { new Registry() };

            registers.ForEach(reg =>
            {
                reg.Register(container);
            });

            return container;
        }
    }
}
