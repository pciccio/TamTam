using DryIoc;

namespace TamTam.Interfaces.IoCRegister
{
	/// <summary>
	/// Provides methods to register the module classes into the container
	/// </summary>
	public interface IIoCRegister
	{
		void Register(IContainer container);
	}
}
