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

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Requests = new BloodRequestRepository(context);
            Banks = new BloodBankRepository(context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}