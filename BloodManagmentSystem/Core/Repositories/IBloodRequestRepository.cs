using BloodManagmentSystem.Core.Models;

namespace BloodManagmentSystem.Core.Repositories
{
    public interface IBloodRequestRepository
    {
        void Add(BloodRequest request);
    }
}