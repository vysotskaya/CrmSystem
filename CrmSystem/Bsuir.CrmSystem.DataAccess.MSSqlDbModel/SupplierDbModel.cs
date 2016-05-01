using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bsuir.CrmSystem.DataAccess.MSSqlDbModel
{
    [Table("Suppliers")]
    public class SupplierDbModel
    {
        public int Id { get; set; }
        [Required]
        public string SupplierName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string SupplierPhone { get; set; }
        [Required]
        public string Discount { get; set; }

        public virtual ICollection<SupplierOrderDbModel> SuppliersOrders { get; set; }
    }
}
