using ComputingC6.Models.Student;
using Microsoft.EntityFrameworkCore;

namespace ComputingC6.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> Student { get; set; }
    }
}
