using DMS.Entities;
namespace DMS.Repositories
{
    public interface ITrafficTypeRep : IRepository<TrafficType>
    {

    }

    public class TrafficTypeRep : Repository<TrafficType>, ITrafficTypeRep
    {
        public TrafficTypeRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }
}