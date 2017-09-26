using BloodManagmentSystem.Core.Models;
using BloodManagmentSystem.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace BloodManagmentSystem.Persistance.Repositories
{
    public class BloodBankRepository : IBloodBankRepository
    {
        private readonly ApplicationDbContext _context;

        public BloodBankRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<BloodBank> GetBloodBanks()
        {
            return _context.Banks.ToList();
        }
    }
}