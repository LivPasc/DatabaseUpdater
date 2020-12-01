using DatabaseUpdater.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseUpdater.DAL
{
    public class DataAccessContext : DbContext
    {
        public DataAccessContext(DbContextOptions<DataAccessContext> options)
            : base(options)
        {
        }
        public DbSet<ValuesModel> ValuesModels { get; set; }

    }
}
