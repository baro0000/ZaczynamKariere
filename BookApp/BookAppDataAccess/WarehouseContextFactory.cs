using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BookAppDataAccess
{
    public class WarehouseContextFactory : IDesignTimeDbContextFactory<WarehouseAppContext>
    {
        public WarehouseAppContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<WarehouseAppContext>();
            optionBuilder.UseSqlServer("Data Source=DESKTOP-CBK7MCF\\SQLEXPRESS;Initial Catalog=WarehouseStorage;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            return new WarehouseAppContext(optionBuilder.Options);
        }
    }
}
