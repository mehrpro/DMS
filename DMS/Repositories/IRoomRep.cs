using DMS.Entities;
namespace DMS.Repositories
{
    public interface IRoomRep : IRepository<Room>
    {

    }

    public class RoomRep : Repository<Room>, IRoomRep
    {
        public RoomRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }
}