using DMS.Entities;

namespace DMS.Repositories
{

    public interface ICreditWarningRep : IRepository<CreditWarning>
    {

    }

    public class CreditWarningRep : Repository<CreditWarning>, ICreditWarningRep
    {
        public CreditWarningRep(ApplicationDbContext context) : base(context)
        {

        }

        private ApplicationDbContext ApplicationDbContext => Context as ApplicationDbContext;
    }

}