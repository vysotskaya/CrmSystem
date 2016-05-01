namespace Bsuir.CrmSystem.DataAccess.Entities
{
    public class SupplierOrder : IEntity
    {
        public int Id { get; set; }
        public double FirstMonth { get; set; }
        public double SecondMonth { get; set; }
        public double ThirdMonth { get; set; }
        public double TotalSum { get; set; }
        public double TotalSumWithDiscount { get; set; }
        public int SupplierRefId { get; set; }
        public int MaterialRefId { get; set; }
    }
}
