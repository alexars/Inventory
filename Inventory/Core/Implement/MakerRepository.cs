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
    //    private InventoryContext context;
        public MakerRepository(InventoryContext context):base(context)
        {
            
        }

        public override void Update(Maker entityToUpdate)
        {
            base.Update(entityToUpdate);
        }
        //{
        //    var maker = context.Makers.Find(id);
        //    if (maker != null)
        //    {
        //        maker.Name = newName;
        //        context.SaveChanges();
        //    }
        //}
    }
}
