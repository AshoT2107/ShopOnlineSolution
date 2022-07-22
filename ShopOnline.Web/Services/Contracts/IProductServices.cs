using ShopOnline.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnline.Web.Services.Contracts
{
    public interface IProductServices
    {
        Task<IEnumerable<ProductDto>> GetItems();
    }
}
