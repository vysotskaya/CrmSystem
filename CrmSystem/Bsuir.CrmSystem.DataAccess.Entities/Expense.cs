namespace Bsuir.CrmSystem.DataAccess.Entities
{
    public class Expense : IEntity
    {
        public int Id { get; set; }
        public double ExpenseOnSquire { get; set; }
        public int WallpaperTypeRefId { get; set; }
        public int MaterialRefId { get; set; }
    }
}
