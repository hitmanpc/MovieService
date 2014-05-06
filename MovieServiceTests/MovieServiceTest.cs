using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service.Entities.Movies;

namespace MovieServiceTests
{
    [TestClass]

    public class MovieServiceTest
    {
        [TestMethod]
        [ExpectedException(typeof(System.ServiceModel.FaultException))]
        public void Movie_Service_Throws_APIKEY_Not_Provided()
        {
            var movieServie = new MovieService.MovieService(null);

        }

        [TestMethod]
        [ExpectedException(typeof(System.ServiceModel.FaultException))]
        public void Configuration_Throws_Exception_On_Invalid_APIKEY()
        {
            var movieServie = new MovieService.MovieService("12983471naslkas812l");

            var dataset = movieServie.GetConfiguration();
        }

        [TestMethod]
        [ExpectedException(typeof(System.ServiceModel.FaultException))]
        public void Movie_Search_Throws_FaultException()
        {
            var movieServie = new MovieService.MovieService("12983471naslkas812l");

            var dataset = movieServie.SearchMovies("Cool");
        }

        [TestMethod]
        public void HttpClientRequest_Type_Compare_Is_Equal()
        {
            var clientRequest = new MovieService.HttpClientRequest<MovieSearch>();

            var dataReturned = clientRequest.GetRequest(new Uri(
                "http://api.themoviedb.org/3/search/keyword?api_key=60d380e21b9fd186dd18f2d5104beb08&query=Club"));

             
             Assert.AreEqual(typeof(MovieSearch).Name, dataReturned.GetType().Name);
        }
    }
}
