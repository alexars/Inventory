using Inventory.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Core.Repositories;

namespace Inventory.Core.Implement
{
    public class ModelRepository : GenericRepository<Model>,IModelRepoitory
    {
        public ModelRepository(InventoryContext context) : base(context)
        {
        }
    }
}
