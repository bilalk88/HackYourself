using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
  public class CookiesController : Controller
  {
    public ActionResult Index(string c)
    {
      ViewBag.CookieString = c;

      var cookieCollection = new HttpCookieCollection();

      if (!string.IsNullOrEmpty(c))
      {
        foreach (var cookie in c.Split(';').Select(pair => pair.Split('=')))
        {
          cookieCollection.Add(new HttpCookie(cookie[0], cookie.Length > 1 ? cookie[1] : string.Empty));
        }
      }

      return View(cookieCollection);
    }
  }
}
