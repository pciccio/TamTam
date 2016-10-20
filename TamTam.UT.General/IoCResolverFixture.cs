using System.Linq;
using DryIoc;
using FluentAssertions;
using NUnit.Framework;
using TamTam.IoCContainer;

namespace TamTam.UT.General
{
	[TestFixture]
	public class IoCResolverFixture
	{
		#region -- Properties, Mocks and Setup --------------------------------------------------------------------------------------------
		private IContainer _container;

		[SetUp]
		public void Setup()
		{
			_container = TamTamContainer.Container;
		}
		#endregion -- Properties, Mocks and Setup -----------------------------------------------------------------------------------------

		#region -- Tests ------------------------------------------------------------------------------------------------------------------

		[Test]
		public void should_register_assemblies_for_null_container()
		{
			IContainer testContainer = null;

			// -- Act ---------------------------------------------------------------------------------------------------------------------
			testContainer = IoCResolver.IoCResolver.Resolve(testContainer);

			// -- Assert ------------------------------------------------------------------------------------------------------------------
			testContainer.Should().NotBeNull();
            
			Assert.IsTrue(testContainer.GetServiceRegistrations().Any());
		}
		#endregion -- Tests ---------------------------------------------------------------------------------------------------------------
	}
}
