using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Core.Domain
{
    public class Maker
    {
        public Maker()
        {
            Models = new HashSet<Model>();
        }
        public Guid MakerID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Model> Models { get; set; }
    }
}
