using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Core.Repositories;

namespace Inventory.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IDepartmentRepository Departments { get; }
        IEqTypeRepository EqTypes { get; }
        ILicenceRepository Licences { get; }
        IMakerRepository Makers { get; }
        IModelRepoitory Models { get; }
        IPersonRepository Persons { get; }
        IUnitRepository Units { get; }
        void SaveAll();
       

    }
}
