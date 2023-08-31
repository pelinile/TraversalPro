using Microsoft.EntityFrameworkCore;

namespace SignalRApi.DAL
{
    public class Context :DbContext
    {
   
        public Context(DbContextOptions<Context> options):base(options)
        {
            
        }
        public DbSet<Visitor> Visitors { get; set; }
    }
}
//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//{
//    optionsBuilder.UseSqlServer("server=LAPTOP-17C08SR4\\SQLEXPRESS;database=MyVisitDb;integrated security=true;");
//}