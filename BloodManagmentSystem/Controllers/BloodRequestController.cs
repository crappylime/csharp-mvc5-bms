using BloodManagmentSystem.Core;
using System.Web.Mvc;

namespace BloodManagmentSystem.Controllers
{
    public class BloodRequestController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public BloodRequestController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}