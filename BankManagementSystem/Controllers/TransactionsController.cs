using BankManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly DataContext _db;

        public TransactionsController(DataContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetAlltransactions()
        {
            var transaction = _db.Transactions.ToList();
            return Ok(transaction);
        }

        [HttpGet("{int id}")]
        public IActionResult GetAlltransactions(int id)
        {
            var transaction = _db.Transactions.FirstOrDefault(x => x.Id == id);
            if(transaction == null)
            {
                Console.WriteLine("Empty Field");
            }
            return Ok(transaction);
        }

        [HttpDelete("{int id}")]
        public IActionResult DeleteAlltransactions(int id)
        {
            var transaction = _db.Transactions.FirstOrDefault(x => x.Id == id);
            if (transaction == null)
            {
                Console.WriteLine("Empty Field");
            }
            _db.Transactions.Remove(transaction);
            _db.SaveChanges();
            return Ok(transaction);
        }
    }
}
