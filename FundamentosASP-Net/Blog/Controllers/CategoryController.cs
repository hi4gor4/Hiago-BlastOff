using Blog.Data;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.Controllers
{
    public class CategoryController : ControllerBase
    {
        [HttpGet("v1/categories")]
        public async Task<IActionResult> Get(
            [FromServices]BlogDataContext context
        )
        {
            var categories  = await context.Categories.ToListAsync();
            return Ok(categories);
        }
        [HttpGet("v1/categories/{id:int}")]
        public async Task<IActionResult> GetOne(
            [FromRoute] int id,
            [FromServices]BlogDataContext context 
        )
        {
            var categories  = await context
                .Categories
                .FirstOrDefaultAsync(x=> x.Id == id);
            if(categories == null)
                return NotFound();
            return Ok(categories);
        }

        [HttpPost("v1/categories/")]
        public async Task<IActionResult> Post(
            [FromBody] Category model,
            [FromServices]BlogDataContext context 
        )
        {
            await context.Categories.AddAsync(model);
            await context.SaveChangesAsync();

            return Created($"v1/categories/{model.Id}", model);
        }

        [HttpPut("v1/categories/{id:int}")]
        public async Task<IActionResult> Put(
            [FromRoute] int id,
            [FromBody] Category model,
            [FromServices]BlogDataContext context 
        )
        {
            var category  = await context
                .Categories
                .FirstOrDefaultAsync(x=> x.Id == id);
            if(category == null)
                return NotFound();
                
            category.Name = model.Name;
            category.Slug = model.Slug;
            category.Posts = model.Posts;
            context.Categories.Update(category);
            await context.SaveChangesAsync();
            return Ok(model);
        }

    }    
}