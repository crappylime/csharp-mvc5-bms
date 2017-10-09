using BloodManagmentSystem.Core.Models;
using System.Collections.Generic;

namespace BloodManagmentSystem.Core.Repositories
{
    public interface IConfirmationRepository
    {
        void AddRange(IEnumerable<Confirmation> confirmations);
        IEnumerable<Confirmation> GetConfirmationsWithDonorsToRequest(int requestId);
        Confirmation GetByHash(string hash);
        void Update(Confirmation confirmation);
    }
}