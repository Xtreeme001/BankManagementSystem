using BankManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BankManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly DataContext _db;

        public CustomersController(DataContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetAllcustomers()
        {
            var customer = _db.Customers.ToList();
            return Ok(customer);
        }

        [HttpGet("{int id}")]
        public IActionResult GetAllcustomers(int id)
        {
            var customer = _db.Customers.FirstOrDefault(x => x.Id == id);
            if(customer == null)
            {
                Console.WriteLine("Empty Fields");
            }
            return Ok(customer);
        }

        [HttpDelete("{int id }")]
        public IActionResult DeleteAllcustomers( int id )
        {
            var customer = _db.Customers.FirstOrDefault(x => x.Id==id);
            if(customer == null)
            {
                Console.WriteLine("Empty Fields");
            }
            _db.Customers.Remove(customer);
            _db.SaveChanges();

            return Ok(customer);
        }
    }
}
