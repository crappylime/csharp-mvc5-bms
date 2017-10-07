using BloodManagmentSystem.Core;
using BloodManagmentSystem.Core.Models;
using BloodManagmentSystem.Core.Repositories;
using BloodManagmentSystem.Persistance.Repositories;

namespace BloodManagmentSystem.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IBloodRequestRepository Requests { get; }
        public IBloodBankRepository Banks { get; }
        public IDonorRepository Donors { get; }
        public IConfirmationRepository Confirmations { get; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Confirmations = new ConfirmationRepository(context);
            Requests = new BloodRequestRepository(context);
            Banks = new BloodBankRepository(context);
            Donors = new DonorRepository(context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}