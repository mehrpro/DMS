using DMS.Entities;

namespace DMS.Repositories
{
    public interface IDestinationRep : IRepository<Destination>
    {

    }

    public class DestinationRep : Repository<Destination>, IDestinationRep
    {
        public DestinationRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }
}