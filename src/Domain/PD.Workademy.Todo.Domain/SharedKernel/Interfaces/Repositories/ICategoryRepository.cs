using PD.Workademy.Todo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.Workademy.Todo.Domain.SharedKernel.Interfaces.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
        Category GetCategory(Guid guid);
        Category UpdateCategory(Guid guid, Category category);
        Category DeleteCategory(Guid guid);
        Category AddCategory(Category category);
    }
}
