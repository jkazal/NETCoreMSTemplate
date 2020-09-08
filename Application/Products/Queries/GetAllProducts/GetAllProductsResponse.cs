using System.Text.Json.Serialization;

namespace Application.Products.Queries.GetAllProducts
{
    public class GetAllProductsResponse
    {
        [JsonPropertyName("productName")]
        public string ProductName { get; set; }
    }
}