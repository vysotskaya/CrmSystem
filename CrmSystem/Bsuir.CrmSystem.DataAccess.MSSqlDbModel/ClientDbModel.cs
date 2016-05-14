using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bsuir.CrmSystem.DataAccess.MSSqlDbModel
{
    [Table("Clients")]
    public class ClientDbModel
    {
        public int Id { get; set; }
        [Required]
        public string ClientName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string ClientPhone { get; set; }
        [Required]
        public double Discount { get; set; }

        public virtual ICollection<OrderArchiveDbModel> OrderArchives { get; set; }
        public virtual ICollection<ClientOrderDbModel> ClientOrders { get; set; }
    }
}
