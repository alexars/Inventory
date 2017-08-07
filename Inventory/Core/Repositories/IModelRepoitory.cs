using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Core.Domain;
using System.Collections.ObjectModel;

namespace Inventory.Core.Repositories
{
    public interface IModelRepoitory : IRepository<Model>
    {
        ObservableCollection<object> GetModelsWithMakers();
    }
}
