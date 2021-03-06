﻿using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Application.Products.Commands.CreateProduct;
using Application.Products.Queries.GetAllProducts;

namespace Infrastructure.JsonPlaceholderApi
{
    public class JsonPlaceholderClient : BaseHttpClient
    {
        public JsonPlaceholderClient(HttpClient httpClient) : base(httpClient)
        {
            
        }

        public async Task<IEnumerable<GetAllProductsResponse>> GetAllProducts()
        {
            return await Get<IEnumerable<GetAllProductsResponse>>(Endpoints.Products.GetAllProducts);
        }

        public async Task<CreateProductResponse> CreateProduct(CreateProductRequest request)
        {
            return await Post<CreateProductResponse>(Endpoints.Products.CreateProduct, request);
        }
    }
}