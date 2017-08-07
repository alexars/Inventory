using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Core.Domain
{
    public class EqType
    {
        public EqType()
        {
            Models = new HashSet<Model>();
        }
        public Guid EqTypeID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public virtual ICollection<Model> Models { get; set; }
    }
}