namespace PaymentContext.Domain.Entities
{
    public class Subscription
    {
        public Subscription(DateTime? expireDate)
        {
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            ExpireDate = expireDate;
            Active = true;
            _payments = new List<Payment>();
        }

        private List<Payment> _payments;
        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public IReadOnlyCollection<Payment> Payments { get { return _payments; } }
        public bool Active { get; private set; }

        public void AddPayment(Payment payment)
        {
            _payments.Add(payment);
        }
        public void SetActive(bool active)
        {
            Active = active;
            LastUpdateDate = DateTime.Now;
        }
    }
}