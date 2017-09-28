using BloodManagmentSystem.Core;
using BloodManagmentSystem.Core.Models;
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

        [HttpGet]
        public ActionResult Index()
        {
            var requests = _unitOfWork.Requests.GetAllInProgressRequests();
            return View(requests);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var model = new BloodRequestFormViewModel
            {
                Banks = _unitOfWork.Banks.GetBloodBanks()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BloodRequestFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Banks = _unitOfWork.Banks.GetBloodBanks();
                return View("Create", model);
            }

            var request = new BloodRequest
            {
                BloodType = model.BloodType,
                DueDateTime = model.GetDueDateTime(),
                City = model.City,
                BankId = model.Bank
            };

            _unitOfWork.Requests.Add(request);
            _unitOfWork.Complete();
            
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var request = _unitOfWork.Requests.GetRequest(id);
            var requestDetails = new BloodRequestDetailsViewModel
            {
                Request = request,
                Donors = _unitOfWork.Donors.GetDonorsByBloodType(request.BloodType)
            };

            return View(requestDetails);
        }

    }
}