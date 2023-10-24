using Microsoft.EntityFrameworkCore;

namespace BankManagementSystem.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Customer> Customers { get; set; }  
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Loan> Loans { get; set; }  
    }
}
