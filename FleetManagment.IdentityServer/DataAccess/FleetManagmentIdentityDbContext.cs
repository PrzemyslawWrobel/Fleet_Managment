using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FleetManagment.IdentityServer.DataAccess
{
    public class FleetManagmentIdentityDbContext : IdentityDbContext
    { 
        public FleetManagmentIdentityDbContext(DbContextOptions<FleetManagmentIdentityDbContext> options) : base(options)
        {

        }
    }
}
