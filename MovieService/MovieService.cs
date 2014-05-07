using System;
using System.ServiceModel;
using Service.Entities.Configuration;
using Service.Entities.Movies;

namespace MovieService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class MovieService : IMovieService
    {
        private string baseAddress = @"http://api.themoviedb.org/3/";

        private string _apiKey;

        public string APIKEY
        {
            get { return "?api_key=" + _apiKey; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException("APIKey cannot be null");
                _apiKey = value;
            }
        }

        
        public Configuration GetConfiguration()
        {
            
            var address = baseAddress + "configuration" + APIKEY;
            var uri = new Uri(address);
            
            var request = new HttpClientRequest<Configuration>();
            return request.GetRequest(uri);
        }


        public MovieSearch SearchMovies(string movieQuery)
        {
            var address = baseAddress + "search/movie" + APIKEY + "&query=" + movieQuery;
            var uri = new Uri(address);
            var request = new HttpClientRequest<MovieSearch>();

            return request.GetRequest(uri);
        }


        public void SetApiKey(string apiKey)
        {
            APIKEY = apiKey;
        }
    }
}
