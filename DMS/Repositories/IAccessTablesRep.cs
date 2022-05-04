using DMS.Entities;

namespace DMS.Repositories
{
    public interface IAccessTableRep : IRepository<AccessTable>
    {

    }

    public class AccessTableRep : Repository<AccessTable>, IAccessTableRep
    {
        public AccessTableRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }
}