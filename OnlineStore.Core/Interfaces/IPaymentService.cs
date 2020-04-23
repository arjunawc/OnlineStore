using System.Threading.Tasks;
using OnlineStore.Core.Entities;
using OnlineStore.Core.Entities.OrderAggregate;

namespace OnlineStore.Core.Interfaces
{
    public interface IPaymentService
    {
        Task<CustomerBasket> CreateOrUpdatePaymentIntent(string basketId);
        Task<Order> UpdateOrderPaymentSucceeded(string paymentIntentId);
        Task<Order> UpdateOrderPaymentFailed(string paymentIntentId);
    }
}
