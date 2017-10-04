using BloodManagmentSystem.Core;
using BloodManagmentSystem.Core.Models;
using BloodManagmentSystem.Core.ViewModels;
using System.Web.Mvc;

namespace BloodManagmentSystem.Controllers
{
    public class EmailServiceController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmailServiceController( IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: EmailService
        public ActionResult Index(int id)
        {
            var request = _unitOfWork.Requests.GetRequest(id);
            var requestDetails = new BloodRequestDetailsViewModel
            {
                Request = request,
                Donors = _unitOfWork.Donors.GetDonorsByBloodType(request.BloodType)
            };

            foreach (var donor in requestDetails.Donors)
            {
                var email = new ConfirmationEmail("Confirmation", donor);
                email.SendAsync();
            }

            return RedirectToAction("Index", "BloodRequest");
        }
    }
}