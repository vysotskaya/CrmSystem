namespace Bsuir.CrmSystem.DataAccess.Entities
{
    public class OrderArchive : IEntity
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int Quarter { get; set; }
        public int Month { get; set; }
        public double TotalSum { get; set; }
        public int ClientRefId { get; set; }
    }
}
