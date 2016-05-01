using System.Data.Entity;

namespace Bsuir.CrmSystem.DataAccess.MSSqlDbModel
{
    public class CrmSystemDbInitializer : DropCreateDatabaseIfModelChanges<DbModelContext>
    {
        protected override void Seed(DbModelContext context)
        {
            //IList<TaskStateDbModel> states = new List<TaskStateDbModel>()
            //{
            //    new TaskStateDbModel() {TaskStateName = "Active"},
            //    new TaskStateDbModel() {TaskStateName = "Completed"}
            //};
            //foreach (TaskStateDbModel state in states)
            //{
            //    context.Set<TaskStateDbModel>().Add(state);
            //}

            base.Seed(context);
        }
    }
}
