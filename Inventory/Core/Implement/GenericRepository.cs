using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Core.Repositories;
using Inventory.Core.Domain;
using System.Data.Entity;
namespace Inventory.Core.Implement
{
    public abstract class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected InventoryContext context;
        public GenericRepository(InventoryContext context)
        {
            this.context = context;
        }
        public void Create(TEntity entity)
        {
            if (entity==null)
            {
                throw new ArgumentNullException("entity");
            }
            context.Set<TEntity>().Add(entity);
        }

        public void Delete(Guid id)
        {
            TEntity entity = context.Set<TEntity>().Find(id);
            if (entity!=null)
            {
                context.Set<TEntity>().Remove(entity);
            }
        }

        public TEntity Get(Guid id)
        {
            return context.Set<TEntity>().Find(id);
        }
        
        public virtual ObservableCollection<TEntity> GetAll()
        {
            context.Set<TEntity>().Load();
            return context.Set<TEntity>().Local;
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            
            //define new entityToUpdate
            
            context.Set<TEntity>().Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }
       
    }
}
