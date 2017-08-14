using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Core.Domain
{
    public class Person
    {
        public Guid PersonID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public Nullable<Guid> DepartmentID { get; set; }

        public virtual Department Department { get; set; }

    }
}
