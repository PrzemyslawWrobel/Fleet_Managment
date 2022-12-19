using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManagment.Application.Common.Interfaces
{
    public interface ICurrentUserService
    {
        string Email { get; set; }
        bool IsAuthenticated { get; set; }
    }
}
