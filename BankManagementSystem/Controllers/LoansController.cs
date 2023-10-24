using BankManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoansController : ControllerBase
    {
        private readonly DataContext _db;

        public LoansController(DataContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetAllloans()
        {
            var loan = _db.Loans.ToList();
            return Ok(loan);
        }

        [HttpGet("{int id}")]
        public IActionResult GetAllloans(int id)
        {
            var loan = _db.Loans.FirstOrDefault(x => x.Id == id);
            if (loan == null)
            {
                Console.WriteLine("Empty Field");
            }
            return Ok(loan);
        }

        [HttpDelete("{int id}")]
        public IActionResult DeleteAllloans(int id)
        {
            var loan = _db.Loans.FirstOrDefault(x => x.Id == id);
            if (loan == null)
            {
                Console.WriteLine("Empty Field");
            }
            _db.Loans.Remove(loan);
            _db.SaveChanges();

            return Ok(loan);
        }
    }
}
