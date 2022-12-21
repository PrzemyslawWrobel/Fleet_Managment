using FleetManagment.Application.Customers.Queries.GetCustomers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FleetManagment.Api.Controllers
{
    /// <summary>
    /// Kontroler odp za obsługę użytkowników
    /// </summary>
    [Route("api/customers")]

    public class CustomersController : BaseController
    {
        /// <summary>
        /// Zwraca listę użytkowników
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(StatusCodes.Status403Forbidden, Type = typeof(ErrorModel))]
        public async Task<ActionResult<GetCustomersVm>> GetCustomersAsync()
        
        {
            var vm = await Mediator.Send(new GetCustomersQuery());
            return Ok(vm);//"Customer Controller";
        }

        ///// <summary>
        ///// Zwraca użytkownika po id
        ///// </summary>
        ///// <returns></returns>
        //[HttpGet("{id}")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task<ActionResult<GetCustomerDetailVm>> GetCustomerDetails(int id)
        //{
        //    var vm = await Mediator.Send(new GetCustomerDetailQuery() { CustomerId = id });
        //    return vm;
        //}
    }
}