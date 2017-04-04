using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace Inventory.Core.Repositories
{
    //Basic functionality for all Repositories
    public interface IRepository<TEntity> where TEntity:class
    {
        //Get entities
        ObservableCollection<TEntity> GetAll();
        TEntity Get(Guid id);
        void Create(TEntity item);
        void Update(TEntity item);
        void Delete(Guid id);
       
      
    }
}
