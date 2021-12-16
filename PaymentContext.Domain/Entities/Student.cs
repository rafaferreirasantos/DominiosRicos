using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();

            AddNotifications(name, document, email);
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }
        public Address? Address { get; private set; }

        private List<Subscription> _subscriptions;

        public void AddSubscription(Subscription subscription)
        {
            foreach (Subscription sub in Subscriptions)
                sub.SetActive(false);
            _subscriptions.Add(subscription);
        }
    }
}