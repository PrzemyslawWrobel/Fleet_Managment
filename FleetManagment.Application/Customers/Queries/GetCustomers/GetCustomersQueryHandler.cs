using AutoMapper;
using AutoMapper.QueryableExtensions;
using FleetManagment.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FleetManagment.Application.Customers.Queries.GetCustomers
{
    public class GetCustomersQueryHandler : IRequestHandler<GetCustomersQuery, GetCustomersVm>
    {
        private readonly IFleetManagmentDbContext _context;
        private readonly IMapper _mapper;

        public GetCustomersQueryHandler(IMapper mapper, IFleetManagmentDbContext fleetManagmentDbContext)
        {
            _context = fleetManagmentDbContext;
            _mapper = mapper;
        }

        public async Task<GetCustomersVm> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var customers = await _context.Customers.AsNoTracking().ProjectTo<CustomerDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
                customers.OrderBy(p => p.Name).ToList();
                return new GetCustomersVm(customers);//{ Customers = customers };
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
