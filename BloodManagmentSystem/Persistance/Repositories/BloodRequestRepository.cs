using BloodManagmentSystem.Core.Models;
using BloodManagmentSystem.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public void Add(BloodRequest request)
        {
            _context.Requests.Add(request);
        }

        public BloodRequest GetRequest(int requestId)
        {
            return _context.Requests.SingleOrDefault(r => r.Id == requestId);
        }

        public IEnumerable<BloodRequest> GetAllInProgressRequests()
        {
            return _context.Requests
                .Where(r => r.DueDate > DateTime.Now)
                .Include(r => r.Bank)
                .ToList();
        }
    }
}