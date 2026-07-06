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
            var Product = _dbContext.Products.Find(id);
            if (Product is null)
                return null;
            return Product;
        }
        public int Add(Product product)
        {
            _dbContext.Products.Add(product);
            return _dbContext.SaveChanges();
        }
        public int update(Product product)
        {
            _dbContext.Products.Update(product);
            return _dbContext.SaveChanges();
        }

        public int Delete(Product product)
        {
            _dbContext.Products.Remove(product);
            return _dbContext.SaveChanges();
        }



        
    }
}
