using FleetManagment.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FleetManagment.Application.Customers.Queries.GetCustomers
{
    public class GetCustomersQueryHandler : IRequestHandler<GetCustomersQuery, GetCustomersVm>
    {
        private readonly IFleetManagmentDbContext _context;
        public GetCustomersQueryHandler(IFleetManagmentDbContext fleetManagmentDbContext)
        {
            _context = fleetManagmentDbContext;
        }
        public async Task<GetCustomersVm> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
        {
            //TODO
            var customers = await _context.Customers.ToListAsync();// .FirstOrDefaultAsync(cancellationToken);
            customers.OrderBy(p => p.Name).ToList();
            throw new Exception();//customers;


            //return customerVm;
        }
    }
}
