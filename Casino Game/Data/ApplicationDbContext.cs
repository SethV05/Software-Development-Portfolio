using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SVassey_FinalProject_CPT206_A80H.Models;

namespace SVassey_FinalProject_CPT206_A80H.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<BankAccount> BankAccounts { get; set; }

        public DbSet<GameRecord> GameRecords { get; set; }
    }
}