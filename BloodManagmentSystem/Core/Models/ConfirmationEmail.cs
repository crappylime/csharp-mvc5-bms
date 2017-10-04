using Postal;

namespace BloodManagmentSystem.Core.Models
{
    public class ConfirmationEmail : Email
    {
        public Donor Donor { get; private set; }
        public ConfirmationEmail(string viewName, Donor donor) : base (viewName)
        {
            Donor = donor;
        }
    }
}