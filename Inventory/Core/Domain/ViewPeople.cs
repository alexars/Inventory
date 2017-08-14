using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Core.Domain
{
    [Table("View_PeopleDepartments")]
   public class ViewPeople
    {
        [Key]
        public Guid PersonID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public string Expr1 { get; set; }
    }
}
