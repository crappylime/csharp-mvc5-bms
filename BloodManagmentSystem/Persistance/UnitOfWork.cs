using BloodManagmentSystem.Core;
using BloodManagmentSystem.Core.Models;
using BloodManagmentSystem.Core.Repositories;
using BloodManagmentSystem.Persistance.Repositories;

namespace BloodManagmentSystem.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IBloodRequestRepository Requests { get; private set; }
        public IBloodBankRepository Banks { get; private set; }
        public IDonorRepository Donors { get; private set; }

        public UnitOfWork(ApplicationDbContext context, IDonorRepository donors)
        {
            _context = context;
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