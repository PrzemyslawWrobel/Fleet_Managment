using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManagment.Domain.Common
{
    public class AuditableEntity
    {
        //public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? Modified { get; set; }

        /// <summary>
        /// poniższe property służą do dezaktywacji danych/użytkowników a nie usuwanie fizyczne z bazy
        /// </summary>
        public int StatusId { get; set; }
        public string InactivatedBy { get; set; }
        public DateTime? Inactivated { get; set; }

    }
}
