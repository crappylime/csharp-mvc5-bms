using BloodManagmentSystem.Core.Repositories;

namespace BloodManagmentSystem.Core
{
    public interface IUnitOfWork
    {
        IBloodRequestRepository BloodRequests { get; }
        IBloodBankRepository BloodBanks { get; }
        void Complete();
    }
}