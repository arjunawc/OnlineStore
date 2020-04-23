using OnlineStore.Core.Entities.OrderAggregate;

namespace OnlineStore.Core.Specifications
{
    public class OrderByPaymentIntentIdWithItemsSpecification : BaseSpecification<Order>
    {
        public OrderByPaymentIntentIdWithItemsSpecification(string paymentIntentId)
            : base(o => o.PaymentIntentId == paymentIntentId)
        {
        }
    }
}
