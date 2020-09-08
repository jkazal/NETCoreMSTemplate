namespace Infrastructure.JsonPlaceholderApi
{
    public class Endpoints
    {
        public class Products
        {
            private const string ProductsPath = "/posts";

            public static string GetAllProducts => ProductsPath;
            public static string CreateProduct => ProductsPath;
            public static string GetProductById(int productId) => $"{ProductsPath}/{productId}";
            public static string GetCommentsForProduct(int productId) => $"{ProductsPath}/{productId}/comments";
        }
    }
}