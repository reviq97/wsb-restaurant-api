using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsb_restaurant_models.EFMigration.Models.LinkingTables
{
    public class EmployeeContact
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ContactId { get; set; }
    }
}
