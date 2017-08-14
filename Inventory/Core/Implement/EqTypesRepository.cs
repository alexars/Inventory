using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Core.Repositories;
using Inventory.Core.Domain;

namespace Inventory.Core.Implement
{
    public class EqTypesRepository : GenericRepository<EqType>, IEqTypeRepository
    {
        public EqTypesRepository(InventoryContext context) : base(context)
        {
        }
    }
}
