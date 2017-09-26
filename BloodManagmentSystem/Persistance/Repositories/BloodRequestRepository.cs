using BloodManagmentSystem.Core.Models;
using BloodManagmentSystem.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace BloodManagmentSystem.Persistance.Repositories
{
    public class BloodRequestRepository : IBloodRequestRepository
    {
        private readonly ApplicationDbContext _context;

        public BloodRequestRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<BloodRequest> GetBloodRequestsBy(int id)
        {
            return _context.Requests
                .Where(r => r.Id == id)
                .ToList();
        }

    }
}