using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Core.Domain;
using Inventory.Core.Repositories;
using System.Data.Entity;
using System.Data.SqlClient;
using Inventory.Core.Domain;

namespace Inventory.Core.Implement
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {

        public PersonRepository(InventoryContext context) : base(context)
        {

        }
        public override ObservableCollection<Person> GetAll()
        {

            var people = context.People
                .Include(d=>d.Departments);

            return new ObservableCollection<Person>(people.ToList());
        }
        public List<object> GetPersonsWithDepts()
        {
            List<object> persons = new List<object>();
            //from с in categories
            //select new { с.Сategory_Id, с.Name, ProductNumber = с.Product.Number };
            //var list = from c in context.People
            //           select new { c.PersonID, c.Name, c.DepartmentID, DepartmentsName = c.Departments.Name };
            //foreach (var item in list)
            //{
            //    persons.Add(item);
            //}
//
            return persons;

        }
        public ObservableCollection<object> GetPersonsWithDepartments()
        {
            ObservableCollection<object> people = new ObservableCollection<object>();
            var search = (from p in context.People
         .Include("Departments")
                          select new
                          {
                              p.PersonID,
                              p.Name,
                              Department = p.Departments.Name
                          });
           

            foreach (var item in search)
            {
                people.Add(item);
            }
            return people;
        }
    }
}
