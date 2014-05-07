using System.Web.Mvc;

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
	}
}