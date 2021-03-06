﻿using AutoMapper;
using Microsoft.Extensions.Configuration;
using OnlineStore.API.Dtos;
using OnlineStore.Core.Entities;

namespace OnlineStore.API.Helpers
{
    public class ProductUrlResolver : IValueResolver<Product, ProductToReturnDto, string>
    {
        private readonly IConfiguration _config;

        public ProductUrlResolver(IConfiguration config)
        {
            _config = config;
        }

        public string Resolve(Product source, ProductToReturnDto destination, string destMember, 
            ResolutionContext context)
        {
            if(!string.IsNullOrEmpty(source.PictureUrl))
            {
                return _config["ContentUrl"] + source.PictureUrl;
            }

            return null;
        }
    }
}
