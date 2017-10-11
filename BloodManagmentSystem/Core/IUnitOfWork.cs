using BloodManagmentSystem.Core.Repositories;

namespace BloodManagmentSystem.Core
{
    public interface IUnitOfWork
    {
        IBloodRequestRepository Requests { get; }
        IBloodBankRepository Banks { get; }
        IDonorRepository Donors { get; }
        IConfirmationRepository Confirmations { get; }
        void Complete();
    }
}