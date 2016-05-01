using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bsuir.CrmSystem.DataAccess.MSSqlDbModel
{
    [Table("ClientOrders")]
    public class ClientOrderDbModel
    {
        public int Id { get; set; }
        [Required]
        public double FirstMonth { get; set; }
        [Required]
        public double SecondMonth { get; set; }
        [Required]
        public double ThirdMonth { get; set; }
        public int ClientRefId { get; set; }
        public int ProductRefId { get; set; }

        public virtual ClientDbModel Client { get; set; }
        public virtual ProductDbModel Product { get; set; }
    }
}
