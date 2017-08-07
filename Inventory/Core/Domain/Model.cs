using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Core.Domain
{
    public class Model
    {
        public Model()
        {
            Units = new HashSet<Unit>();
        }
        public Guid ModelID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public Nullable<Guid> MakerID{ get; set; }
        public Nullable<Guid> EqTypeID { get; set; }

        public virtual Maker Makers { get; set; }
        public virtual EqType Eqtypes { get; set; }
        public virtual ICollection<Unit> Units { get; set; }
    }
}
