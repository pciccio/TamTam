using DryIoc;
using FluentAssertions;
using NUnit.Framework;
using TamTam.Interfaces.Business.TamTam;
using TamTam.IoCContainer;
using TamTam.Models.TamTam.Search;

namespace TamTam.UT.General.TamTam
{
    [TestFixture]
    public class AggregatedObject
    {
        #region -- Properties, Mocks and Setup --------------------------------------------------------------------------------------------
        private IAggregatedObject _aggregateObject;

        [SetUp]
        public void Setup()
        {
            var container = IoCResolver.IoCResolver.Resolve(TamTamContainer.Container);
            _aggregateObject = container.Resolve<IAggregatedObject>();
        }
        #endregion -- Properties, Mocks and Setup -----------------------------------------------------------------------------------------

        #region -- Tests ------------------------------------------------------------------------------------------------------------------
        [Test]
        public void should_not_be_null()
        {
            const string title = "Scarface";


            var param = new Parameter
            {
                MovieTitle = title
            };

            // -- Act ---------------------------------------------------------------------------------------------------------------------
            var movie = _aggregateObject.GetAggregatedObjectAsync(param).Result;

            // -- Assert ------------------------------------------------------------------------------------------------------------------
            movie.Should().NotBeNull();
        }
        #endregion -- Tests ---------------------------------------------------------------------------------------------------------------
    }
}


