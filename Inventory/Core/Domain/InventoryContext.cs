﻿using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;

namespace Inventory.Core.Domain
{
    public class InventoryContext : DbContext
    {
        public InventoryContext() : base("name=Inventory")
        {
            //var ensureDLLIsCopied =
            //   System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = false;
            //context.Configuration.ProxyCreationEnabled = false;

        }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Licence> Licences { get; set; }
        public virtual DbSet<Maker> Makers { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<EqType> EqTypes { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<ViewPeople> ViewPeople { get; set; }

    }
}
