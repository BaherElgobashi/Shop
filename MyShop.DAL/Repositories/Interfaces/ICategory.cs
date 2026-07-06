using myshop.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DAL.Repositories.Interfaces
{
    public interface ICategory
    {
        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(int id);
        int Add(Category category);
        int Update(Category category);
        int Delete(Category category);
    }
}
