using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Core.Repositories;
using Inventory.Core.Domain;
using System.Data.Entity;
using System.Collections.ObjectModel;

namespace Inventory.Core.Implement
{
   public class MakerRepository:GenericRepository<Maker>, IMakerRepository
    {
        private InventoryContext context;
        public MakerRepository(InventoryContext context):base(context)
        {
            
        }

        //public void Create(Maker item)
        //{
           
        //    context.Makers.Add(item);
        //}

        //public void Delete(int id)
        //{
        //    Maker maker = context.Makers.Find(id);
        //    if (maker!=null)
        //    {
        //        context.Makers.Remove(maker);
        //    }
        //}

        //public Maker Get(int id)
        //{
        //    return context.Makers.Find(id);
        //}

        //public ObservableCollection<Maker> GetAll()
        //{
        //    context.Makers.Load();
        //    return context.Makers.Local;
        //    //return context.Makers;
        //}

        //public void Update(Maker item)
        //{
        //    context.Entry(item).State = System.Data.Entity.EntityState.Modified;
        //}
    }
}
