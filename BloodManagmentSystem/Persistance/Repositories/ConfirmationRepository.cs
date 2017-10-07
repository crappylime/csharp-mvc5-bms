using BloodManagmentSystem.Core.Models;

namespace BloodManagmentSystem.Persistance.Repositories
{
    public class ConfirmationRepository
    {
        private readonly ApplicationDbContext _context;

        public ConfirmationRepository(ApplicationDbContext context)
        {
            _context = context;
        }


    }
}