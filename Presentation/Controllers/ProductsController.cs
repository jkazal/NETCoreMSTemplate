using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Products.Commands.CreateProduct;
using Application.Products.Queries.GetAllProducts;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class ProductsController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetAllProductsDto>>> GetAllProducts()
        {
            var response = await Mediator.Send(new GetAllProductsQuery());
            return Ok(response);
        }
        
        [HttpPost]
        public async Task<ActionResult<CreateProductDto>> CreateProduct(CreateProductCommand command)
        {
            var response = await Mediator.Send(command);
            return CreatedAtAction(nameof(CreateProduct), response);
        }
    }
}