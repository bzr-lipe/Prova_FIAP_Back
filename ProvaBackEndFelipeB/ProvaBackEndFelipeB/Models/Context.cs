using Microsoft.EntityFrameworkCore;

namespace ProvaBackEndFelipeB.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base (options)
        { 
            
        }

        public DbSet<Funcionario> Produto { get; set; } 
    }
}
