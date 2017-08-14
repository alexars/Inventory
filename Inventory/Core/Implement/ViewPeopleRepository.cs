using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Core.Domain;
using Inventory.Core.Repositories;
using System.Collections.ObjectModel;
using System.Data.Entity;

namespace Inventory.Core.Implement
{
    public class ViewPeopleRepository : GenericRepository<ViewPeopleRepository>, IViewPeopleRepository
    {
        public ViewPeopleRepository(InventoryContext context) : base(context)
        {
        }

        public void Create(ViewPeople item)
        {
            throw new NotImplementedException();
        }

        public void Update(ViewPeople entity)
        {
            throw new NotImplementedException();
        }

        ViewPeople IRepository<ViewPeople>.Get(Guid id)
        {
            throw new NotImplementedException();
        }

        ObservableCollection<ViewPeople> IRepository<ViewPeople>.GetAll()
        {
            context.ViewPeople.Load();
            return context.ViewPeople.Local;
        }
    }
}
