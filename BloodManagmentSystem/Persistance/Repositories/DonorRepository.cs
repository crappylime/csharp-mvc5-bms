using BloodManagmentSystem.Core.Models;
using BloodManagmentSystem.Core.Repositories;

namespace BloodManagmentSystem.Persistance.Repositories
{
    public class DonorRepository : IDonorRepository
    {
        private readonly ApplicationDbContext _context;

        public DonorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Donor donor)
        {
            _context.Donors.Add(donor);
        }
    }
}