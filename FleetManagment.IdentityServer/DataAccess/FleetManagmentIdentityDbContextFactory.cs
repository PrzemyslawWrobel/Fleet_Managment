using Microsoft.EntityFrameworkCore;

namespace FleetManagment.IdentityServer.DataAccess
{
    public class FleetManagmentIdentityDbContextFactory : DesignTimeDbContextFactoryBase<FleetManagmentIdentityDbContext>
    {
        protected override FleetManagmentIdentityDbContext CreateNewInstance(DbContextOptions<FleetManagmentIdentityDbContext> options)
        {
            return new FleetManagmentIdentityDbContext(options);
        }
    }
}