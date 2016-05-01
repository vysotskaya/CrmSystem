namespace Bsuir.CrmSystem.DataAccess.Entities
{
    public class WallpaperType : IEntity
    {
        public int Id { get; set; }
        public int WallparerName { get; set; }
        public bool IsForPainting { get; set; }
    }
}
