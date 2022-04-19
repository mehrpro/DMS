using DMS.Entities;
namespace DMS.Repositories
{
    public interface IDormitoryRep : IRepository<Dormitory>
    {

    }

    public class DormitoryRep : Repository<Dormitory>, IDormitoryRep
    {
        public DormitoryRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }
}