using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Core.Domain
{
    public class Licence
    {
        public Guid LicenceID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(150)]
        public string Description { get; set; }
        public string KeyValue { get; set; }
        public Nullable<Guid> UnitID { get; set; }

        public virtual Unit Units { get; set; }
    }
}