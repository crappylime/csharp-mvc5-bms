using System.Collections.Generic;
using BloodManagmentSystem.Core.Models;

namespace BloodManagmentSystem.Core.Repositories
{
    public interface IConfirmationRepository
    {
        void AddRange(IEnumerable<Confirmation> confirmations);
        IEnumerable<Confirmation> GetConfirmationsWithDonorsToRequest(int requestId);
    }
}