namespace Bsuir.CrmSystem.DataAccess.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public int WallpaperTypeRefId { get; set; }
        public int WallpaperSizeRefId { get; set; }
    }
}
