using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Core.Domain;
using Inventory.Core.Repositories;

namespace Inventory.Core.Implement
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(InventoryContext context) : base(context)
        {
        }
    }
}
