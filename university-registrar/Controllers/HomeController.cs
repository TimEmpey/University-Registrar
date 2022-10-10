using Microsoft.AspNetCore.Mvc;

namespace UniversityRegistrar.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}