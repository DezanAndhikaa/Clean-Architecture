using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Persistences
{
    public class DesignTimeDbContextFactoryBase : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost,1433;Initial Catalog=CarSystem;Persist Security Info=True;User ID=sa;Password=AdminPassword123;");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}