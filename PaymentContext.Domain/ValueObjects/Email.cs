using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public string EmailAddress { get; private set; }

        public Email(string email)
        {
            EmailAddress = email;

            AddNotifications(
                new Contract()
                .Requires()
                .IsEmail(EmailAddress, "Email.EmailAddress", "E-mail inválido"));
        }
    }
}