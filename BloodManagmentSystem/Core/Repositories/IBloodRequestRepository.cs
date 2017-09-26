using BloodManagmentSystem.Core.Models;
using System.Collections.Generic;

namespace BloodManagmentSystem.Core.Repositories
{
    public interface IBloodRequestRepository
    {
        void Add(BloodRequest request);
        BloodRequest GetRequest(int requestId);
        IEnumerable<BloodRequest> GetAllInProgressRequests();

    }
}