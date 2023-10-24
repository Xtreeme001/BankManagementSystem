using BankManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchesController : ControllerBase
    {
        private readonly DataContext _db;

        public BranchesController(DataContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetAllbranches()
        {
            var branch = _db.Branches.ToList();
            return Ok(branch);
        }

        [HttpGet("{int id}")]
        public IActionResult GetAllbranches(int id)
        {
            var branch = _db.Branches.FirstOrDefault(x => x.Id == id);
            if (branch == null)
            {
                Console.WriteLine("Empty Field");
            }
            return Ok(branch);
        }

        [HttpDelete("{int id}")]
        public IActionResult DeleteAllbranches(int id)
        {
            var branch = _db.Branches.FirstOrDefault(x => x.Id == id);
            if (branch == null)
            {
                Console.WriteLine("Empty Field");
            }
            _db.Branches.Remove(branch);  
            _db.SaveChanges();  

            return Ok(branch);
        }
    }
}
