using Postal;

namespace BloodManagmentSystem.Core.Models
{
    public class ConfirmationEmail : Email
    {
        public Confirmation Confirmation { get; private set; }
        public ConfirmationEmail(string viewName, Confirmation confirmation) : base (viewName)
        {
            Confirmation = confirmation;
        }
    }
}