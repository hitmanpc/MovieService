using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.ServiceModel;
using Newtonsoft.Json;
using Service.Entities.Configuration;
using Service.Entities.Exceptions;
using Service.Entities.Movies;

namespace MovieService
{
    //[ServiceBehavior(IncludeExceptionDetailInFaults = false)]
    public class MovieService : IMovieService
    {
        private string baseAddress = @"http://api.themoviedb.org/3/";

        private string _apiKey;

        private string APIKEY
        {
            get { return "?api_key=" + _apiKey; }
            //set { APIKEY = _apiKey; }
        }

        public MovieService()
        {
        }

        public MovieService(string ApiKey)
        {
            if (string.IsNullOrWhiteSpace(ApiKey))
            {
                throw new FaultException(new FaultReason("API Key was not given. Please Provide an API Key."));
            }

            _apiKey = ApiKey;
        }

        public Configuration GetConfiguration()
        {
            //_apiKey = ApiKey;
            var address = baseAddress + "configuration" + APIKEY;
            var uri = new Uri(address);
            
            var request = new HttpClientRequest<Configuration>();
            return request.GetRequest(uri);
        }




        public Service.Entities.Movies.MovieSearch SearchMovies(string movieQuery)
        {
            var address = baseAddress + "search/movie" + APIKEY + "&query=" + movieQuery;
            var uri = new Uri(address);
            var request = new HttpClientRequest<MovieSearch>();

            return request.GetRequest(uri);
        }
    }
}
