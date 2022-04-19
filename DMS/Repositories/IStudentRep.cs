using DMS.Entities;
namespace DMS.Repositories
{
    public interface IStudentRep : IRepository<Student>
    {

    }

    public class StudentRep : Repository<Student>, IStudentRep
    {
        public StudentRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }
}