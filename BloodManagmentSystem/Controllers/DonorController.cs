using System.Web.Mvc;

namespace BloodManagmentSystem.Controllers
{
    public class DonorController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
    }
}