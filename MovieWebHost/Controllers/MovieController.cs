using System.Linq;
using System.Web.Mvc;
using MovieWebHost.Models;

namespace MovieWebHost.Controllers
{
    public class MovieController : Controller
    {
        //
        // GET: /Movie/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchMovies(MovieSearchModel movieSearchModel)
        {

            return PartialView("_SearchResults");
        }

        public ActionResult AutoCompleteTitle(string term)
        {
            var service = new MovieService.MovieService();
            service.APIKEY = "60d380e21b9fd186dd18f2d5104beb08";
            var dataReturn = service.SearchMovies(term);

            var movietitles = dataReturn.results.Select(r => r.title).Take(20);

            

            return Json(movietitles, JsonRequestBehavior.AllowGet);
        }
	}
}