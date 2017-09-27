using BloodManagmentSystem.Core.Models;
using BloodManagmentSystem.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace BloodManagmentSystem.Persistance.Repositories
{
    public class DonorRepository : IDonorRepository
    {
        private readonly ApplicationDbContext _context;

        public DonorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Donor> GetDonorsByBloodType(BloodType type)
        {
            return _context.Donors
                .Where(d => d.BloodType == type)
                .ToList();
        }

    }
}