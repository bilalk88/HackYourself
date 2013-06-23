using System.Web.Mvc;

namespace Web.Controllers
{
  public class CountdownController : Controller
  {
    public ActionResult Index()
    {
      return RedirectToAction("Index", "Home");

      return View();
    }

    [HttpPost]
    public ActionResult Index(string ContentPlaceHolderDefault_BodyContent_CustomerLogin_1_txtUsername, string ContentPlaceHolderDefault_BodyContent_CustomerLogin_1_txtPassword)
    {
      return RedirectToAction("Index", "Home");

      Response.Status = "307 Temporary Redirect";
      Response.AddHeader("Location", "https://www.countdown.co.nz/onecard/panels/customer-login");
      return View("Empty");
    }
  }
}
