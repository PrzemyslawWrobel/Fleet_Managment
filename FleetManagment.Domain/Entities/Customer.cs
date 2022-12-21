using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FleetManagment.Domain.Entities
{
    public class Customer
    {
        public Customer()
        {
            //Addresses = new List<Address>();
        }

        public int Id { get; set; }

        /// <summary>
        /// Nazwa klienta indywidualnego lub firmy
        /// </summary>
        public string Name { get; set; }

    }
}