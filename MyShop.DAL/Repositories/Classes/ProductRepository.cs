using myshop.Entities.Models;
using MyShop.DAL.Contexts;
using MyShop.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DAL.Repositories.Classes
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            var Products = _dbContext.Products.ToList();
            return Products;


        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }
        public int Add(Product product)
        {
            throw new NotImplementedException();
        }

        public int Delete(Product product)
        {
            throw new NotImplementedException();
        }



        public int update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
