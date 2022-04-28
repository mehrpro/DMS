using DMS.Entities;

namespace DMS.Repositories
{
    public interface ITradodRep : IRepository<Tradod>
    {

    }

    public class TradodRep : Repository<Tradod>, ITradodRep
    {
        public TradodRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }
}