using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ClientesAp.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=10.50.30.38;Database=ClientesDb;User Id=sa;Password=BdGrupo4;TrustServerCertificate=True;MultipleActiveResultSets=True");
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}