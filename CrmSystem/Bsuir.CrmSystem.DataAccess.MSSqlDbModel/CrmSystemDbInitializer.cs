using System.Collections.Generic;
using System.Data.Entity;

namespace Bsuir.CrmSystem.DataAccess.MSSqlDbModel
{
    public class CrmSystemDbInitializer : DropCreateDatabaseIfModelChanges<DbModelContext>
    {
        protected override void Seed(DbModelContext context)
        {
            IList<ClientDbModel> clients = new List<ClientDbModel>()
            {
                new ClientDbModel()
                {
                    ClientName = "Иванов П.М.",
                    CompanyName = "ОАО 'СтройЯкОм'",
                    ClientPhone = "+375(29)345-54-13",
                    Discount = 0,
                    Email = "stroyAykOm@gmail.com"
                }
            };
            foreach (var client in clients)
            {
                context.Set<ClientDbModel>().Add(client);
            }

            base.Seed(context);
        }
    }
}
