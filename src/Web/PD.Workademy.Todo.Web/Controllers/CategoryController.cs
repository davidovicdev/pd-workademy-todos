using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace PD.Workademy.Todo.Web.Controllers
{
    [ApiController]
    public class CategoryController : ApiBaseController
    {
        private readonly List<string> _categories = new() { "Easy", "Hard", "Medium", "The hardest", "The easiest"};
        [HttpGet("/api/[controller]")]
        public async Task<ActionResult> GetAllCategoriesAsync()
        {
            return Ok(_categories);
        }
        [HttpGet("/api/[controller]/{id}")]
        public async Task<ActionResult> GetCategoryAsync(Guid id)
        {
            return id != Guid.Empty ? Ok(_categories[0]) : Ok("It's not guid") ;
        }

    }
}
