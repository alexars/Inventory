using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Core.Domain
{
   public class Department
    {
        public Department()
        {
            Persons = new HashSet<Person>();
        }
        public Guid DepartmentID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Person> Persons { get; set; }
    }
}
