using FinancePlan.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinancePlan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetAllCategories()
        {
            var Categories = new List<Category>
            {
                new Category {
                    Id = 1,
                    Name = "College"

                }
            };

            return Ok(Categories);
        }
    }
}
