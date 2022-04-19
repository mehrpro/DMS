using DMS.Entities;
namespace DMS.Repositories
{
    public interface IRegisterRoomRep : IRepository<RegisterRoom>
    {

    }

    public class RegisterRoomRep : Repository<RegisterRoom>, IRegisterRoomRep
    {
        public RegisterRoomRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }
}