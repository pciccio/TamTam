using DryIoc;
using FluentAssertions;
using NUnit.Framework;
using TamTam.Interfaces.Business.YouTube;
using TamTam.IoCContainer;
using TamTam.Models.YouTube.Search;
using TamTam.Models.YouTube.Result;

namespace TamTam.UT.General.YouTube
{
    [TestFixture]
    public class Video
    {
        #region -- Properties, Mocks and Setup --------------------------------------------------------------------------------------------
        private IVideo _video;
        private Parameter parameter;


        [SetUp]
        public void Setup()
        {
            var container = IoCResolver.IoCResolver.Resolve(TamTamContainer.Container);
            _video = container.Resolve<IVideo>();

            parameter = new Parameter
            {
                part = Enumerator.Part.Snippet,
                q = "Scarface",
                type = Enumerator.Type.Video,
                videoEmbeddable = Enumerator.VideoEmbeddable.True,
                videoDuration = Enumerator.VideoDuration.Short,
                videoLicense = Enumerator.VideoLicense.YouTube,
                maxResults = 5,
            };
        }
        #endregion -- Properties, Mocks and Setup -----------------------------------------------------------------------------------------

        #region -- Tests ------------------------------------------------------------------------------------------------------------------
        [Test]
        public void should_not_be_null()
        {
            // -- Act ---------------------------------------------------------------------------------------------------------------------
            var movie = _video.GetVideoAsync(parameter).Result;

            // -- Assert ------------------------------------------------------------------------------------------------------------------
            movie.Should().NotBeNull();
        }

        [Test]
        public void should_five_itens()
        {
            // -- Act ---------------------------------------------------------------------------------------------------------------------
            var movie = _video.GetVideoAsync(parameter).Result;

            // -- Assert ------------------------------------------------------------------------------------------------------------------
            Assert.AreEqual(5, movie.items.Count);
        }
        #endregion -- Tests ---------------------------------------------------------------------------------------------------------------
    }
}