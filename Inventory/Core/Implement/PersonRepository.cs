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
        //public override ObservableCollection<Person> GetAll()
        //{

        //    var people = context.People
        //        .Include(d=>d.Departments);

        //    return new ObservableCollection<Person>(people.ToList());
        //}
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


            var people = from p in context.People
                         select new { p.PersonID, p.Name, p.DepartmentID,DepName = p.Department.Name };

         
           
          
           
       


           
            return new ObservableCollection<object>(people.ToList());
        }

       
    }
}
