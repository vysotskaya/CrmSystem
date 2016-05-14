namespace Bsuir.CrmSystem.DataAccess.Entities
{
    public class Supplier : IEntity
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string SupplierPhone { get; set; }
        public double Discount { get; set; }
    }
}
