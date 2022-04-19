using System.Threading.Tasks;
using DMS.Entities;

namespace DMS.Repositories
{
    public interface IApplicationUserRep : IRepository<ApplicationUser>
    {
        Task<bool> Login(string username, string pass);
    }

    public class ApplicationUserRep : Repository<ApplicationUser>, IApplicationUserRep
    {
        public ApplicationUserRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }

        public async Task<bool> Login(string username, string pass)
        {
            var resultfind = await FindCondition(x => x.Username == username && x.Password == pass);
            if (resultfind == null) return false;
            return true;
        }
    }
}