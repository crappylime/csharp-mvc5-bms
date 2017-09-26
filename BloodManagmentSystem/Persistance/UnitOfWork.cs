using BloodManagmentSystem.Core;
using BloodManagmentSystem.Core.Models;
using BloodManagmentSystem.Core.Repositories;
using BloodManagmentSystem.Persistance.Repositories;

namespace BloodManagmentSystem.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IBloodRequestRepository BloodRequests { get; private set; }
        public IBloodBankRepository BloodBanks { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            BloodRequests = new BloodRequestRepository(context);
            BloodBanks = new BloodBankRepository(context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}