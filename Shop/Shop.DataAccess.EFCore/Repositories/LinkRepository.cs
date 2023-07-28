using Microsoft.EntityFrameworkCore;
using Shop.BusinessLogic.DataAccessInterfaces;
using Shop.BusinessLogic.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.DataAccess.EFCore.Repositories
{
    public class LinkRepository : ILinkRepository
    {
        private readonly ShopDbContext _context;

        public LinkRepository(ShopDbContext context)
        {
            _context = context;
        }

        public Link Create(Link link)
        {
            _context.Entry(link).State = EntityState.Added;

            return link;
        }

        public List<Link> GetAll()
        {
            return _context.Links.ToList();
        }
    }
}
