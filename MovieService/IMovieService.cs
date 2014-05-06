using System;
using System.ServiceModel;
using Service.Entities.Configuration;
using Service.Entities.Movies;

namespace MovieService
{
    [ServiceContract]
    public interface IMovieService
    {
        [OperationContract]
        Configuration GetConfiguration();

        [OperationContract]
        MovieSearch SearchMovies(string movieQuery);
    }

}
