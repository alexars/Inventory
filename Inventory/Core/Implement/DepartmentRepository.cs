using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Core.Repositories;
using Inventory.Core.Domain;

namespace Inventory.Core.Implement
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(InventoryContext context) : base(context)
        {
        }
    }
}
