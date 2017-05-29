using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Core.Domain;
using Inventory.Core.Repositories;
using System.Data.Entity;
using System.Data.SqlClient;
namespace Inventory.Core.Implement
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
      
        public PersonRepository(InventoryContext context) : base(context)
        {

        }
        //TODO: make changes
      public ObservableCollection<Person> GetPersonsWithDepartments()
        {
            var pList = (from p in context.People
                         select p).
                        Include(d => d.Departments.ID);
            ObservableCollection<Person> list=new ObservableCollection<Person>();
            foreach (var item in pList)
            {
                list.Add(item);
            }
            return list;
        }
    }
}
