using Microsoft.EntityFrameworkCore;
using Shop.BusinessLogic.DataAccessInterfaces;
using Shop.BusinessLogic.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.DataAccess.EFCore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShopDbContext _context;

        public ProductRepository(ShopDbContext context)
        {
            _context = context;
        }

        public Product Create(Product product)
        {
            _context.Entry(product).State = EntityState.Added;

            return product;
        }

        public Product Delete(int productId)
        {
            var deletableProduct = _context.Products.FirstOrDefault(x => x.Id == productId);

            _context.Entry(deletableProduct).State = EntityState.Deleted;

            return deletableProduct;
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product Update(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;

            return product;
        }
    }
}
