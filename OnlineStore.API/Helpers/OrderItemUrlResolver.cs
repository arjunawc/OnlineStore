using AutoMapper;
using Microsoft.Extensions.Configuration;
using OnlineStore.API.Dtos;
using OnlineStore.Core.Entities.OrderAggregate;

namespace OnlineStore.API.Helpers
{
    public class OrderItemUrlResolver : IValueResolver<OrderItem, OrderItemDto, string>
    {
        private readonly IConfiguration _config;

        public OrderItemUrlResolver(IConfiguration config)
        {
            _config = config;
        }

        public string Resolve(OrderItem source, OrderItemDto destination, string destMember, 
            ResolutionContext context)
        {
            if(!string.IsNullOrEmpty(source.ItemOrdered.PictureUrl))
            {
                return _config["ContentUrl"] + source.ItemOrdered.PictureUrl;
            }

            return null;
        }
    }
}
