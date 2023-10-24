using BankManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly DataContext _db;

        public AccountsController(DataContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetAllaccounts()
        {
            var account = _db.Accounts.ToList();
            return Ok(account);
        }

        [HttpGet("{int id}")]
        public IActionResult GetAllaccounts(int id)
        {
            var account = _db.Accounts.FirstOrDefault(x => x.Id == id);
            if(account == null)
            {
                Console.WriteLine("Empty Fields");
            }
            return Ok(account);
        }

        [HttpDelete("{int id}")]
        public IActionResult DeleteAllaccounts(int id)
        {
            var account = _db.Accounts.FirstOrDefault(x => x.Id == id);
            if (account == null)
            {
                Console.WriteLine("Empty Fields");
            }
            _db.Accounts.Remove(account);
            _db.SaveChanges();
            return Ok(account);
        }
    }
}
