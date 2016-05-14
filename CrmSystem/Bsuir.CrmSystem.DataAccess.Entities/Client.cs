namespace Bsuir.CrmSystem.DataAccess.Entities
{
    public class Client : IEntity
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string ClientPhone { get; set; }
        public double Discount { get; set; }
    }
}
