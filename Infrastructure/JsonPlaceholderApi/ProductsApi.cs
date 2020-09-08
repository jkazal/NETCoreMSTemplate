using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Products;
using Application.Products.Commands.CreateProduct;
using Application.Products.Queries.GetAllProducts;
using Domain.Entities;
using Infrastructure.Services;

namespace Infrastructure.JsonPlaceholderApi
{
    public class ProductsApi : IProductsApi
    {
        private ProductsService _productsService;
        //public ProductsApi(JsonPlaceholderClient client)
        //{
        //    _client = client;
        //}

        public ProductsApi(ProductsService productsService)
        {
            _productsService = productsService;
        }
        
        public async Task<IEnumerable<Vsproduct>> GetAllProducts()
        {
            return await _productsService.GetAllProducts();
        }

        public async Task<CreateProductResponse> CreateProduct(CreateProductRequest request)
        {
            // return await _client.CreateProduct(request);
            return null;
        }
    }
}