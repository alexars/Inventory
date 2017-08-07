using Inventory.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Core.Repositories;
using System.Collections.ObjectModel;

namespace Inventory.Core.Implement
{
    public class ModelRepository : GenericRepository<Model>,IModelRepoitory
    {
        public ModelRepository(InventoryContext context) : base(context)
        {
        }

        private ObservableCollection<object> list = new ObservableCollection<object>();
        public ObservableCollection<object> GetModelsWithMakers()
        {
            var modelsWithMakers = (from m in context.Models
                                    .Include("Makers")
                                    select new
                                    {
                                        Maker = m.Makers.Name,
                                        MakerID = m.Makers.MakerID,
                                        Model = m.Name,
                                        ModelID = m.ModelID
                                    }).ToList();
            foreach (var item in modelsWithMakers)
            {
                list.Add(item);
            }
            return list;
        }
    }
}
