using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ShopOnline.Web.Services
{
    public class ProductService : IProductServices
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<ProductDto>> GetItems()
        {
            try
            {
                var products = await httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/Product");
                return products;
            }                                       
            catch (Exception)
            {
                throw;
            }
        }
    }
}
