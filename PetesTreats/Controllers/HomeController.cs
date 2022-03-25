using Microsoft.AspNetCore.Mvc;

namespace PetesTreats.Controllers
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