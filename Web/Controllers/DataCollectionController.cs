using System.Web.Mvc;

namespace Web.Controllers
{
  public class DataCollectionController : Controller
  {
    [HttpPost]
    public ActionResult Index(FormCollection formCollection)
    {
      return View(formCollection);
    }
  }
}
