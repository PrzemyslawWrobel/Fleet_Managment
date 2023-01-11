using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FleetManagment.Application.Common.Interfaces
{
    public interface ITerytClient
    {
        Task<string> GetAdress(string searchFilter, CancellationToken cancellationToken);
    }
}
