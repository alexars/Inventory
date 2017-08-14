using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Core.Domain;
using Inventory.Core.Repositories;

namespace Inventory.Core.Implement
{
    public class UnitOfWork : IUnitOfWork
    {
        //one Context for all
        private readonly InventoryContext _context = new InventoryContext();
        private IMakerRepository makerRepository;
        private IEqTypeRepository eqTypeRepository;
        private ILicenceRepository licenceRepository;
        private IDepartmentRepository departmentRepository;
        private IModelRepoitory modelRepository;
        private IPersonRepository personRepository;
        private IUnitRepository unitRepository;
        private IViewPeopleRepository viewPeoplRepository;

        public UnitOfWork()
        {
            _context.Database.Log = Console.Write;
        }
        public IMakerRepository Makers
        {
            get
            {
                if (makerRepository == null)
                    makerRepository = new MakerRepository(_context);
                return makerRepository;
            }
        }
        public IEqTypeRepository EqTypes
        {
            get
            {
                if (eqTypeRepository == null)
                    eqTypeRepository = new EqTypesRepository(_context);
                return eqTypeRepository;
            }

        }
        public IModelRepoitory Models
        {
            get
            {
                if (modelRepository == null)
                {
                    modelRepository = new ModelRepository(_context);
                }
                return modelRepository;
            }

        }
        public ILicenceRepository Licences
        {
            get
            {
                if (licenceRepository == null)
                    licenceRepository = new LicenceRepository(_context);
                return licenceRepository;
            }
        }
        public IDepartmentRepository Departments
        {
            get
            {
                if (departmentRepository == null)
                    departmentRepository = new DepartmentRepository(_context);
                return departmentRepository;
            }
        }
        public IPersonRepository Persons
        {
            get
            {
                if (personRepository == null)
                    personRepository = new PersonRepository(_context);
                return personRepository;
            }
        }
        public IUnitRepository Units
        {
            get
            {
                if (unitRepository == null)
                    unitRepository = new UnitRepository(_context);
                return unitRepository;
            }
        }
        public IViewPeopleRepository View_PeopleDepartments
        {
            get
            {
                if (viewPeoplRepository == null)
                    viewPeoplRepository = new ViewPeopleRepository(_context);
                return viewPeoplRepository;
            }
        }

        public void SaveAll()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
