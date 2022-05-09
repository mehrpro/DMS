using DMS.Entities;

namespace DMS.Repositories
{

    public interface IResourceRep : IRepository<Resource>
    {

    }

    public class ResourceRep : Repository<Resource>, IResourceRep
    {
        public ResourceRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }

}