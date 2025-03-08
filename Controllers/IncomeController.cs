using FinancePlan.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinancePlan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncomeController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Income>>> GetAllIncomes()
        {
            var Incomes = new List<Income>
            {
                new Income {
                    Id = 1,
                    Source = "College",
                    DateTime = DateTime.Now,
             
                }
            };

            return Ok(Incomes);


        }
    }
}
