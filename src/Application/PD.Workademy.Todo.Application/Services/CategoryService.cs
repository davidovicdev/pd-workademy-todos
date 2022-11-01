using PD.Workademy.Todo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.Workademy.Todo.Application.Services
{
    public class CategoryService : ICategoryService
    {
        public List<Category> GetCategories()
        {
            List<Category> categories =
                new()
                {
                    new Category(new Guid("4e25d511-2d2f-4a03-bda6-210b5facf14b"), "Easy"),
                    new Category(new Guid("83a933d4-d2ca-47df-9250-b3dbbab1d80a"), "Medium"),
                    new Category(new Guid("da1b99b4-a559-4c74-8844-ada3bdee7e48"), "Hard"),
                };
            return categories;
        }
    }
}
