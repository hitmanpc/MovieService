using System.Collections.Generic;
using Service.Entities.Movies;

namespace MovieWebHost.Models
{
    public class MovieSearchModel
    {
        public List<MovieSearch> Movies;
        public string MovieQuery;
    }
}