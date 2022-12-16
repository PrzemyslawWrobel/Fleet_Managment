using FleetManagment.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetManagment.Application.Common.Interfaces;
using FleetManagment.Domain.Entities;

namespace FleetManagment.DataAccess
{
    public class FleetManagmentDbContext : DbContext, IFleetManagmentDbContext
    {
        public FleetManagmentDbContext(DbContextOptions<FleetManagmentDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
