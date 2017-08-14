using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Core.Domain;
using System.Collections.ObjectModel;

namespace Inventory.Core.Repositories
{
    public interface IPersonRepository : IRepository<Person>
    {
        //    ObservableCollection<object> GetPersonsWithDepartments();
         List<object> GetPersonsWithDepts();
        ObservableCollection<object> GetPersonsWithDepartments();
    //    ObservableCollection<View_PeopleDepartments> GetPersonsView();
    }
}
