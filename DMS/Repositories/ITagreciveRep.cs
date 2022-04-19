using DMS.Entities;
namespace DMS.Repositories
{
    public interface ITagreciveRep : IRepository<Tagrecive>
    {

    }

    public class TagreciveRep : Repository<Tagrecive>, ITagreciveRep
    {
        public TagreciveRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }
}