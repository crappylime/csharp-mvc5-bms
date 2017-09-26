using BloodManagmentSystem.Core.Models;
using System.Collections.Generic;

namespace BloodManagmentSystem.Core.Repositories
{
    public interface IBloodBankRepository
    {
        IEnumerable<BloodBank> GetBloodBanks();
    }
}