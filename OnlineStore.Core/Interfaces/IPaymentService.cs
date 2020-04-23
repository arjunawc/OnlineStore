using System.Threading.Tasks;
using OnlineStore.Core.Entities;

namespace OnlineStore.Core.Interfaces
{
    public interface IPaymentService
    {
         Task<CustomerBasket> CreateOrUpdatePaymentIntent(string basketId);
    }
}