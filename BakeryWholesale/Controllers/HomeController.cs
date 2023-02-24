using Microsoft.AspNetCore.Mvc;

namespace BakeryWholesale.Controllers
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