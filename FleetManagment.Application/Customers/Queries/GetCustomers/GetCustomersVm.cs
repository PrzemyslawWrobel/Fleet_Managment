using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManagment.Application.Customers.Queries.GetCustomers
{
    public class GetCustomersVm
    {
        public GetCustomersVm(ICollection<CustomerDtoApi> customers)
        {
            Customers = customers;
        }

        public ICollection<CustomerDtoApi> Customers { get; set; }
    }
}
