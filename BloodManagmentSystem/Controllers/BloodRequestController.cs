using BloodManagmentSystem.Core;
using BloodManagmentSystem.Core.Models;
using BloodManagmentSystem.Core.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
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

        public ActionResult Notify(int id)
        {
            var request = _unitOfWork.Requests.GetRequest(id);
            if (request == null)
                return HttpNotFound();

            var donors = _unitOfWork.Donors.GetDonorsByBloodType(request.BloodType);

            var confirmations = CreateConfirmations(donors, id);

            _unitOfWork.Confirmations.AddRange(confirmations);
            _unitOfWork.Complete();

            Task.Factory.StartNew(() => SendEmails(confirmations));

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Confirm(string hash)
        {
            return RedirectToAction("Index");
        }

        #region PrivateMethods

        private IEnumerable<Confirmation> CreateConfirmations(IEnumerable<Donor> donors, int requestId)
        {
            return donors.Select(donor => new Confirmation
            {
                Donor = donor,
                RequestId = requestId,
                HashCode = GetMd5HashCode($"{donor.Id}dnr"),
                Status = false
            }).ToList();
        }

        private string GetMd5HashCode(string input)
        {
            var md5 = MD5.Create();

            var result = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            var sb = new StringBuilder();

            foreach (var b in result)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }

        private void SendEmails(IEnumerable<Confirmation> confirmations)
        {
            foreach (var confirmation in confirmations)
            {
                var email = new ConfirmationEmail("Confirmation", confirmation);
                email.SendAsync();
            }
        }

        #endregion
    }
}