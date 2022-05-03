using DMS.Entities;

namespace DMS.Repositories
{
    public interface IElementUserRep : IRepository<ElementUser>
    {

    }

    public class ElementUserRep : Repository<ElementUser>, IElementUserRep
    {
        public ElementUserRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }
}