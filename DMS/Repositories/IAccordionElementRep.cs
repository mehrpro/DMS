using DMS.Entities;

namespace DMS.Repositories
{
    public interface IAccordionElementRep : IRepository<AccordionElement>
    {

    }

    public class AccordionElementRep : Repository<AccordionElement>, IAccordionElementRep
    {
        public AccordionElementRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }
}