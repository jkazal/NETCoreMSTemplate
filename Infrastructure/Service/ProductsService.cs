using Application.Products.Queries.GetAllProducts;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ProductsService
    {
        private readonly MLLJK_VictoriaContext _context;
        public ProductsService(MLLJK_VictoriaContext context)
        {
            this._context = context;
        }
        public async Task<IEnumerable<Vsproduct>> GetAllProducts()
        {
            return _context.Vsproduct.ToList();
        }
    }
}
