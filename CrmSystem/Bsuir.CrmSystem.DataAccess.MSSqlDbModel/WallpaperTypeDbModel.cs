using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bsuir.CrmSystem.DataAccess.MSSqlDbModel
{
    [Table("WallparerTypes")]
    public class WallpaperTypeDbModel
    {
        public int Id { get; set; }
        [Required]
        public int WallparerName { get; set; }
        [Required]
        public bool IsForPainting { get; set; }

        public virtual ICollection<ProductDbModel> Products { get; set; }
        public virtual ICollection<ExpenseDbModel> Expenses { get; set; }
    }
}
