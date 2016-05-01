using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bsuir.CrmSystem.DataAccess.MSSqlDbModel
{
    [Table("WallpaerSizes")]
    public class WallpaperSizeDbModel
    {
        public int Id { get; set; }
        [Required]
        public double Width { get; set; }

        public virtual ICollection<ProductDbModel> Products { get; set; } 
    }
}
