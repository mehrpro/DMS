using DMS.Entities;
namespace DMS.Repositories
{
    public interface IRegisterTagRep : IRepository<RegisterTag>
    {

    }

    public class RegisterTagRep : Repository<RegisterTag>, IRegisterTagRep
    {
        public RegisterTagRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }
}