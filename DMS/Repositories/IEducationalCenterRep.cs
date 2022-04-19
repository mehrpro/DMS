using DMS.Entities;
namespace DMS.Repositories
{
    public interface IEducationalCenterRep : IRepository<EducationalCenter>
    {

    }

    public class EducationalCenterRep : Repository<EducationalCenter>, IEducationalCenterRep
    {
        public EducationalCenterRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }
}