using System.Collections.Generic;

namespace OnlineStore.Core.Entities
{
    public class CustomerBasket
    {
        public CustomerBasket()
        {
        }

        public CustomerBasket(string id)
        {
            Id = id;
        }

        public string Id { get; set; }
        public List<CustomerBasketItem> Items { get; set; } = new List<CustomerBasketItem>();
    }
}
