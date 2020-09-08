using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Products;
using Application.Products.Commands.CreateProduct;
using Application.Products.Queries.GetAllProducts;

namespace Infrastructure.JsonPlaceholderApi
{
    public class ProductsApi : IProductsApi
    {
        private readonly JsonPlaceholderClient _client;

        public ProductsApi(JsonPlaceholderClient client)
        {
            _client = client;
        }
        
        public async Task<IEnumerable<GetAllProductsResponse>> GetAllProducts()
        {
            return await _client.GetAllProducts();
        }

        public async Task<CreateProductResponse> CreateProduct(CreateProductRequest request)
        {
            return await _client.CreateProduct(request);
        }
    }
}