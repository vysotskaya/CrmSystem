using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bsuir.CrmSystem.DataAccess.MSSqlDbModel
{
    [Table("OrdersArchive")]
    public class OrderArchiveDbModel
    {
        public int Id { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public int Quarter { get; set; }
        [Required]
        public int Month { get; set; }
        [Required]
        public double TotalSum { get; set; }
        public int ClientRefId { get; set; }

        public virtual ClientDbModel Client { get; set; }

    }
}
