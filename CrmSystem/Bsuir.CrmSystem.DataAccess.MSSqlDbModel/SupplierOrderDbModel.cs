using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bsuir.CrmSystem.DataAccess.MSSqlDbModel
{
    [Table("SupplierOrders")]
    public class SupplierOrderDbModel
    {
        public int Id { get; set; }
        [Required]
        public double FirstMonth { get; set; }
        [Required]
        public double SecondMonth { get; set; }
        [Required]
        public double ThirdMonth { get; set; }
        [Required]
        public double TotalSum { get; set; }
        [Required]
        public double TotalSumWithDiscount { get; set; }
        public int SupplierRefId { get; set; }
        public int MaterialRefId { get; set; }

        public virtual SupplierDbModel Supplier { get; set; }
        public virtual MaterialDbModel Material { get; set; }
    }
}
