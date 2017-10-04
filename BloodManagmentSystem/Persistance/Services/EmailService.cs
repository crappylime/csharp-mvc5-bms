using BloodManagmentSystem.Core.Models;
using Postal;
using System.Collections.Generic;

namespace BloodManagmentSystem.Persistance.Services
{
    public class EmailService
    {
        public ICollection<Donor> Recipients { get; private set; }

        public EmailService(ICollection<Donor> donors)
        {
            Recipients = donors;
        }

        public void SendEmails()
        {
            foreach (var recipient in Recipients)
            {
                dynamic email = new Email("Confirmation");
                email.To = recipient.Email;
                email.SendAsync();
            }
        }
    }
}