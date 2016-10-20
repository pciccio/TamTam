using DryIoc;
using FluentAssertions;
using NUnit.Framework;
using TamTam.Interfaces.Business.OMDb;
using TamTam.IoCContainer;
using TamTam.Models.OMDb.Search;

namespace TamTam.UT.General.OMDb
{
    [TestFixture]
    public class Movie
    {
        #region -- Properties, Mocks and Setup --------------------------------------------------------------------------------------------
        private IMovie _movie;

        const string Title = "Scarface";
        
        [SetUp]
        public void Setup()
        {
            var container = IoCResolver.IoCResolver.Resolve(TamTamContainer.Container);
            _movie = container.Resolve<IMovie>();
        }
        #endregion -- Properties, Mocks and Setup -----------------------------------------------------------------------------------------

        #region -- Tests ------------------------------------------------------------------------------------------------------------------
        [Test]
        public void should_not_be_null()
        {
            var param = new ParameterByIdOrTitle
            {
                MovieTitle = Title
            };

            // -- Act ---------------------------------------------------------------------------------------------------------------------
            var movie = _movie.GetMovieAsync(param).Result;

            // -- Assert ------------------------------------------------------------------------------------------------------------------
            movie.Should().NotBeNull();
        }


        [Test]
        public void should_have_same_title_as_search()
        {
            var param = new ParameterByIdOrTitle
            {
                MovieTitle = Title
            };

            // -- Act ---------------------------------------------------------------------------------------------------------------------
            var movie = _movie.GetMovieAsync(param).Result;

            // -- Assert ------------------------------------------------------------------------------------------------------------------
            Assert.AreEqual(movie.Title, Title);
        }

        [Test]
        public void should_have_same_id_as_search()
        {
            const string imdbId = "tt0086250";

            var param = new ParameterByIdOrTitle
            {
                ImdbId = imdbId
            };

            // -- Act ---------------------------------------------------------------------------------------------------------------------
            var movie = _movie.GetMovieAsync(param).Result;

            // -- Assert ------------------------------------------------------------------------------------------------------------------
            Assert.AreEqual(movie.ImdbId, imdbId);
        }
        #endregion -- Tests ---------------------------------------------------------------------------------------------------------------
    }
}


