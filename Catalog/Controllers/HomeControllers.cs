using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
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