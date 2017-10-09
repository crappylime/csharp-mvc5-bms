using BloodManagmentSystem.Core.Models;
using System.Collections.Generic;

namespace BloodManagmentSystem.Core.ViewModels
{
    public class BloodRequestDetailsViewModel
    {
        public BloodRequest Request { get; set; }
        public IEnumerable<Donor> Donors { get; set; }
    }
}