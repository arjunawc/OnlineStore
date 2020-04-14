using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.API.Dtos
{
    public class CustomerBasketDto
    {
        [Required]
        public string Id { get; set; }

        public List<CustomerBasketItemDto> Items { get; set; }
    }
}
