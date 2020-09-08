using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Products.Commands.CreateProduct;
using Application.Products.Queries.GetAllProducts;

namespace Application.Products
{
    public interface IProductsApi
    {
        Task<IEnumerable<GetAllProductsResponse>> GetAllProducts();
        Task<CreateProductResponse> CreateProduct(CreateProductRequest request);
    }
}