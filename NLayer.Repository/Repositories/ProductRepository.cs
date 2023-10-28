using Microsoft.EntityFrameworkCore;
using NLayer.Core;
using NLayer.Core.Model;
using NLayer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<List<Product>> GetProductsWithCategory()
        {

            //eager loading yaptık yani datayı ilk çekerken beraberinde kategorisinide çektik.
            //lazy loading ise sonradan çekme işlemidir.
            return await _context.Products.Include(p => p.Category).ToListAsync();
        }
    }
}
