using DMS.Entities;
namespace DMS.Repositories
{
    public interface IStudyRep : IRepository<Study>
    {

    }

    public class StudyRep : Repository<Study>, IStudyRep
    {
        public StudyRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }
}