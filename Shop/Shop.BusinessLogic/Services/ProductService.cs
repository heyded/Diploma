using Shop.BusinessLogic.DataAccessInterfaces;
using Shop.BusinessLogic.Models;
using Shop.BusinessLogic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.BusinessLogic.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductRepository _productRepository;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _productRepository = unitOfWork.ProductRepository;
        }

        public Product Create(Product product, string categoryName)
        {
            var categories = _unitOfWork.CategoryRepository.GetAll();
            var category = categories.FirstOrDefault(c => c.Name.Equals(categoryName, StringComparison.OrdinalIgnoreCase));

            var produts = _productRepository.GetAll();
            product.Id = produts.Any() ? produts.Max(x => x.Id) + 1 : 1;

            var link = new Link
            {
                CategoryId = category.Id,
                ProductId = product.Id
            };

            _unitOfWork.LinkRepository.Create(link);
            _productRepository.Create(product);
            _unitOfWork.SaveChenges();

            return product;
        }

        public Product Get(string productName)
        {
            var products = _productRepository.GetAll();
            var product = products.FirstOrDefault(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

            return product;
        }

        public List<Product> GetAll(string categoryName)
        {
            var products = _productRepository.GetAll();
            var categories = _unitOfWork.CategoryRepository.GetAll();
            var links = _unitOfWork.LinkRepository.GetAll();

            var categoryId = categories.FirstOrDefault(category => category.Name.Equals(categoryName)).Id;
            var categoryLinks = links.Where(link => link.CategoryId == categoryId);
            var productIds = categoryLinks.Select(categoryLink => categoryLink.ProductId);
            var filteredProducts = products.Where(product => productIds.Contains(product.Id));

            return filteredProducts.ToList();
        }

        public List<Product> GetOrderedProducts(string userEmail)
        {
            var allOrders = _unitOfWork.OrderRepository.GetAll().ToList();
            var userOrders = allOrders.Where(x => x.UserEmail.Equals(userEmail, StringComparison.OrdinalIgnoreCase));
            var userProductIds = userOrders.Select(x => x.ProductId);
            var products = _productRepository.GetAll();
            var orderedProducts = userProductIds.Select(id => products.FirstOrDefault(x => x.Id == id)).ToList();

            return orderedProducts;
        }

        public Product Buy(int productId, string userEmail)
        {
            var product = _productRepository.GetAll().FirstOrDefault(x => x.Id == productId);
            var order = new Order
            {
                UserEmail = userEmail,
                ProductId = productId,
            };

            _unitOfWork.OrderRepository.Create(order);
            _unitOfWork.SaveChenges();

            return product;
        }

        public Product Update(Product product)
        {
            var updatedProduct = _productRepository.Update(product);

            _unitOfWork.SaveChenges();

            return updatedProduct;
        }

        public Product Delete(int productId)
        {
            var deletedProduct = _productRepository.Delete(productId);

            _unitOfWork.SaveChenges();

            return deletedProduct;
        }

        public Product DeleteOrderedProduct(int productId, string userEmail)
        {
            var deletableProduct = _productRepository.GetAll().FirstOrDefault(x => x.Id == productId);
            var deletableOrder = _unitOfWork.OrderRepository.GetAll().FirstOrDefault(x => x.UserEmail.Equals(userEmail, StringComparison.OrdinalIgnoreCase) && x.ProductId == productId);
            _unitOfWork.OrderRepository.Delete(deletableOrder);

            _unitOfWork.SaveChenges();

            return deletableProduct;
        }

        public List<Product> PayOrderedProducts(string userEmail)
        {
            var userOrders = _unitOfWork.OrderRepository.GetAll().Where(x => x.UserEmail.Equals(userEmail, StringComparison.OrdinalIgnoreCase));
            var userProductIds = userOrders.Select(x => x.ProductId);
            var orderedProducts = _productRepository.GetAll().Where(x => userProductIds.Contains(x.Id)).ToList();

            userOrders.ToList().ForEach(x => _unitOfWork.OrderRepository.Delete(x));
            _unitOfWork.SaveChenges();

            return orderedProducts;
        }
    }
}
