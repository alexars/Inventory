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
        private ObservableCollection<object> people = new ObservableCollection<object>();
        public ObservableCollection<object> GetPersonsWithDepartments()
        {
            var search = (from p in context.People
         .Include("Departments")
                          select new
                          {
                              p.ID,
                              p.Name,
                              Department = p.Departments.Name
                          }).ToList();


            foreach (var item in search)
            {
                people.Add(item);
            }
            return people;
        }
    }
}
