using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bsuir.CrmSystem.DataAccess.MSSqlDbModel
{
    [Table("Expenses")]
    public class ExpenseDbModel
    {
        public int Id { get; set; }
        [Required]
        public double ExpenseOnSquire { get; set; }
        public int WallpaperTypeRefId { get; set; }
        public int MaterialRefId { get; set; }

        public virtual WallpaperTypeDbModel WallpaperType { get; set; }
        public virtual MaterialDbModel Material { get; set; }
    }
}
