using DryIoc;

namespace TamTam.IoCContainer
{
    /// <summary>
    /// Creates a container in a static class for easy usage 
    /// </summary>
	public static class TamTamContainer
    {
		private static IContainer _container;
        
		public static IContainer Container => _container ?? (_container = new Container(rules => rules.WithTrackingDisposableTransients()));
	}
}
