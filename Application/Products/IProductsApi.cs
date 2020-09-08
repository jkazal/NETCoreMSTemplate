using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Products.Commands.CreateProduct;
using Application.Products.Queries.GetAllProducts;
using Domain.Entities;

namespace Application.Products
{
    public interface IProductsApi
    {
        Task<IEnumerable<Vsproduct>> GetAllProducts();
        Task<CreateProductResponse> CreateProduct(CreateProductRequest request);
    }
}