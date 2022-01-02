using GeekShopping.Web.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> FindAllproducts();
        Task<ProductModel> FindProductById(long id);
        Task<ProductModel> CreateProduct(ProductModel model);
        Task<ProductModel> UpdateProduct(ProductModel model);            
        Task<bool> DeleteProductById(long id);
    }
}
