using BloodManagmentSystem.Core;
using BloodManagmentSystem.Core.ViewModels;
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
            var requestModel = new BloodRequestFormViewModel
            {
                Banks = _unitOfWork.BloodBanks.GetBloodBanks()
            };

            return View(requestModel);
        }
    }
}