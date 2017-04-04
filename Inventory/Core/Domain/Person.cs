using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Core.Domain
{
    public class Person
    {
        public Guid ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        public virtual Department Departments { get; set; }

    }
}
