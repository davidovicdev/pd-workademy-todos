using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.Workademy.Todo.Application.ApiModels
{
    public class AddUpdateCategoryDTO
    {
        public string Name { get; set; }

        public AddUpdateCategoryDTO() { }

        public AddUpdateCategoryDTO(string name)
        {
            Name = name;
        }
    }
}
