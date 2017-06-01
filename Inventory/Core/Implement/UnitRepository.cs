using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Core.Domain;
using Inventory.Core.Repositories;

namespace Inventory.Core.Implement
{
    public class UnitRepository : GenericRepository<Unit>, IUnitRepository
    {
        public UnitRepository(InventoryContext context) : base(context)
        {
        }
        private ObservableCollection<Unit> unitlist = new ObservableCollection<Unit>();
        public ObservableCollection<object> GetUnitsWithModelsMakers()
        {

            var units = (from u in context.Units
                         .Include("Model")
                         select new { u.ID, u.Model.Name, u.SerialNumber, u.Description }).ToList();
            ObservableCollection<object> list = new ObservableCollection<object>();
            foreach (var item in units)
            {
                list.Add(item);
            }
            return list;
        }


    }
}
