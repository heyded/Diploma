using Microsoft.EntityFrameworkCore;
using Shop.BusinessLogic.DataAccessInterfaces;
using Shop.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.DataAccess.EFCore.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ShopDbContext _context;

        public OrderRepository(ShopDbContext context)
        {
            _context = context;
        }

        public Order Create(Order order)
        {
            _context.Entry(order).State = EntityState.Added;

            return order;
        }

        public Order Delete(Order order)
        {
            _context.Entry(order).State = EntityState.Deleted;

            return order;
        }

        public List<Order> GetAll()
        {
            return _context.Orders.ToList();
        }
    }
}
