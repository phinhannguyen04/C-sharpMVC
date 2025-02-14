using Microsoft.EntityFrameworkCore;
using myTeam.Models;

namespace myTeam.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Contact> Contacts => Set<Contact>();
    }
}
