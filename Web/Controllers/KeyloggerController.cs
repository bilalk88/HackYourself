using System.Web.Mvc;

namespace Web.Controllers
{
  public class KeyloggerController : Controller
  {
    public ActionResult Index(string k)
    {
      ViewBag.Key = k;
      return View();
    }
  }
}
