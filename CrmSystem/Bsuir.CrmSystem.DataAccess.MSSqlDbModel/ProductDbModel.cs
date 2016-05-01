using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bsuir.CrmSystem.DataAccess.MSSqlDbModel
{
    [Table("Products")]
    public class ProductDbModel
    {
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductPrice { get; set; }
        public int WallpaperTypeRefId { get; set; }
        public int WallpaperSizeRefId { get; set; }

        public virtual WallpaperTypeDbModel WallpaperType { get; set; }
        public virtual WallpaperSizeDbModel WallpaperSize { get; set; }
        public virtual ICollection<ClientOrderDbModel> ClientOrders { get; set; } 
    }
}
