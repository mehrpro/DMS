using DMS.Entities;
namespace DMS.Repositories
{
    public interface ITagRep : IRepository<Tag>
    {

    }

    public class TagRep : Repository<Tag>, ITagRep
    {
        public TagRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }
}