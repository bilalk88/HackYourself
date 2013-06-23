using System.Web.Mvc;

namespace Web.Controllers
{
  public class CountdownController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Index(string ContentPlaceHolderDefault_BodyContent_CustomerLogin_1_txtUsername, string ContentPlaceHolderDefault_BodyContent_CustomerLogin_1_txtPassword)
    {
      return Redirect("https://www.countdown.co.nz/onecard/panels/customer-login");
    }
  }
}
