using Shop.BusinessLogic.Models;
using System.Collections.Generic;

namespace Shop.BusinessLogic.Services.Interfaces
{
    public interface IProductService
    {
        public Product Get(string productName);

        public List<Product> GetAll(string categoryName);

        public List<Product> GetOrderedProducts(string userEmail);

        public Product Buy(int productId, string userEmail);

        public Product Create(Product product, string categoryName);

        public Product Update(Product product);

        public Product Delete(int productId);

        public Product DeleteOrderedProduct(int productId, string userEmail);

        public List<Product> PayOrderedProducts(string userEmail);
    }
}
