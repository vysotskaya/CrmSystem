using Bsuir.CrmSystem.DataAccess.Entities;

namespace Bsuir.CrmSystem.DataAccess.Interfaces.Repositories
{
    public interface IExpenseRepository : IRepository<Expense>
    {
        int Create(Expense entity);
        void Update(Expense entity);
        void Delete(Expense entity);
    }
}
