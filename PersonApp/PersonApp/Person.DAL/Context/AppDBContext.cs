using Microsoft.EntityFrameworkCore;

namespace Person.DAL.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext()
        {

        }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Entities.Models.Person> Persons { get; set; }
    }
}
