using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OnlineStore.Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    if (!context.ProductBrands.Any())
                    {
                        var brandsData = File.ReadAllText("../OnlineStore.Infrastructure/Data/SeedData/brands.json");

                        var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);

                        await context.Database.ExecuteSqlRawAsync($"SET IDENTITY_INSERT dbo.ProductBrands ON");
                        foreach (var item in brands)
                        {
                            context.ProductBrands.Add(item);
                        }
                        await context.SaveChangesAsync();
                        await context.Database.ExecuteSqlRawAsync($"SET IDENTITY_INSERT dbo.ProductBrands OFF");
                    }

                    if (!context.ProductTypes.Any())
                    {
                        var typesData = File.ReadAllText("../OnlineStore.Infrastructure/Data/SeedData/types.json");

                        var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);

                        await context.Database.ExecuteSqlRawAsync($"SET IDENTITY_INSERT dbo.ProductTypes ON");
                        foreach (var item in types)
                        {
                            context.ProductTypes.Add(item);
                        }
                        await context.SaveChangesAsync();
                        await context.Database.ExecuteSqlRawAsync($"SET IDENTITY_INSERT dbo.ProductTypes OFF");
                    }

                    if (!context.Products.Any())
                    {

                        var productsData = File.ReadAllText("../OnlineStore.Infrastructure/Data/SeedData/products.json");

                        var products = JsonSerializer.Deserialize<List<Product>>(productsData);

                        foreach (var item in products)
                        {
                            context.Products.Add(item);
                        }
                        await context.SaveChangesAsync();
                    }

                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}
