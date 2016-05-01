using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bsuir.CrmSystem.DataAccess.MSSqlDbModel
{
    [Table("Materials")]
    public class MaterialDbModel
    {
        public int Id { get; set; }
        [Required]
        public string MaterialName { get; set; }

        public virtual ICollection<ExpenseDbModel> Expenses { get; set; }
        public virtual ICollection<SupplierOrderDbModel> SupplierOrders { get; set; }
    }
}
