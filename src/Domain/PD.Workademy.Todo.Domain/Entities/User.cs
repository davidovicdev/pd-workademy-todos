using PD.Workademy.Todo.Domain.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.Workademy.Todo.Domain.Entities
{
    public class User : BaseEntity
    {
        [MaxLength(25)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        public ICollection<TodoItem> TodoItems { get; set; }
    }
}
