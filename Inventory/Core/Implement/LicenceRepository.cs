using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Core.Domain;
using Inventory.Core.Repositories;

namespace Inventory.Core.Implement
{
    public class LicenceRepository : GenericRepository<Licence>, ILicenceRepository
    {
        public LicenceRepository(InventoryContext context) : base(context)
        {
        }
    }
}
