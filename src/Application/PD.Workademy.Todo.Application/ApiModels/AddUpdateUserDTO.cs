using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.Workademy.Todo.Application.ApiModels
{
    public class AddUpdateUserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public AddUpdateUserDTO() { }

        public AddUpdateUserDTO(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
        }
    }
}
