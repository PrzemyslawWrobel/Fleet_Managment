using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManagment.Application.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(300);
            RuleFor(x => x.AgeCustomer).NotNull();
            RuleFor(x => x.ContactPersonFirstName).NotEmpty().MinimumLength(3);
            RuleFor(x => x.ContactPersonLastName).NotEmpty().MinimumLength(3);
        }


    }
}
