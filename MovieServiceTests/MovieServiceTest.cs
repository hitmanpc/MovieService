using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MovieService;
using Service.Entities.Configuration;

namespace MovieServiceTests
{
    [TestClass]

    public class MovieServiceTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Movie_Search_Throws_APIKEY_Not_Provided()
        {
            var wcfMock = new Mock<IMovieService>();
            wcfMock.SetupSet<string>(meth => meth.SearchMovies("data")).Throws<ArgumentException>();
            var SearchValue = wcfMock.Object;

            var SearchReturns = SearchValue.SearchMovies("data");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Set_APIKEY_Throw_Exception_when_NullorEmpty()
        {
            var wcfMock = new Mock<IMovieService>();
            wcfMock.Setup(meth => meth.SetApiKey(null)).Throws<ArgumentNullException>();

            var setApiValue = wcfMock.Object;

            wcfMock.Object.SetApiKey(null);
        }

        [TestMethod]
        public void Set_ApiKey_Method()
        {
            var wcfMock = new Mock<IMovieService>();
            wcfMock.Setup(meth => meth.SetApiKey(It.IsAny<string>()));

            
            wcfMock.Object.SetApiKey("data");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Configuration_Throws_exception_When_ApiKey_NullOrEmpty()
        {
            var wcfMock = new Mock<IMovieService>();
            wcfMock.Setup(meth => meth.GetConfiguration()).Throws<ArgumentNullException>();

            var configValue = wcfMock.Object;

            var configReturns = configValue.GetConfiguration();
        }

        [TestMethod]
        [ExpectedException(typeof(System.ServiceModel.FaultException))]
        public void Configuration_Throws_Exception_On_Invalid_APIKEY()
        {
            var movieServie = new MovieService.MovieService();
            var dataset = movieServie.GetConfiguration();

        }

        
        [TestMethod]
        public void Mock_WCF_Service()
        {
            var wcfMock = new Mock<IMovieService>();

            var configObject = new Mock<Configuration>();

            var called = false;
            wcfMock.Setup(meth => meth.GetConfiguration()).Callback(() => called = true);
            IMovieService value = wcfMock.Object;
            value.GetConfiguration();
            Assert.IsTrue(called == true);
        }
    }
}
