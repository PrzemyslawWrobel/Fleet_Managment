
using AutoMapper;
using FleetManagment.Application.Common.Interfaces;
using FleetManagment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FleetManagment.Application.Customers.Queries.GetCustomers
{
    public class CustomerDtoApi : CustomerDto, IMapFrom<Customer>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Customer, CustomerDtoApi>()
                .ForMember(x => x.Name, map => map.MapFrom(src => src.Name));
        }
    }
}
