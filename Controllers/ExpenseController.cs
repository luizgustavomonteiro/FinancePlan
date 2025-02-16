using FinancePlan.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinancePlan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Expense>>> GetAllExpenses()
        {
            var Expenses = new List<Expense>
            {
                new Expense {
                    Id = 1,
                    Amount = 2,
                    DateTime = DateTime.Now,
                    Description = "College Fees",
                    // Fix how make a category
                  

                }
            };

            return Ok(Expenses);
        }
    }
}
