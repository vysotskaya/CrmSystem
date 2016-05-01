namespace Bsuir.CrmSystem.DataAccess.Entities
{
    public class ClientOrder : IEntity
    {
        public int Id { get; set; }
        public double FirstMonth { get; set; }
        public double SecondMonth { get; set; }
        public double ThirdMonth { get; set; }
        public int ClientRefId { get; set; }
        public int ProductRefId { get; set; }
    }
}
