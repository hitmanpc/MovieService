using System;

namespace MovieConsole
{
    public class MovieUserInterface
    {
        public void RunInterface()
        {
            Console.WriteLine("Enter in the API Key: ");
            var apikey = Console.ReadLine();

            while (true)
            {
                try
                {

                    var movieService = new MovieService.MovieService();
                    movieService.SetApiKey(apikey);
                    var datasent = movieService.GetConfiguration();

                    Console.WriteLine("data sent to service " + apikey + " data returned ");
                    Console.WriteLine("Url to images:" + datasent.images.base_url);

                    Console.WriteLine("Enter Movie Title:");
                    var movieTitle = Console.ReadLine();

                    var movieResults = movieService.SearchMovies(movieTitle);
                    foreach (var result in movieResults.results)
                    {
                        Console.WriteLine("Title:" + result.title);
                        Console.WriteLine("Original Title: " + result.original_title + "\n");

                    }

                }
                catch (Exception exception)
                {

                    Console.WriteLine(exception.Message);
                    break;
                }

            }
        }
    }
}
