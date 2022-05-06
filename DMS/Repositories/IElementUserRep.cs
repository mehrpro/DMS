using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.Data.ODataLinq.Helpers;
using DMS.Entities;

namespace DMS.Repositories
{
    public interface IElementUserRep : IRepository<ElementUser>
    {
        IEnumerable<ElementUser> GetCleamByUserId(int userId);
    }

    public class ElementUserRep : Repository<ElementUser>, IElementUserRep
    {
        public ElementUserRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }

        public IEnumerable<ElementUser> GetCleamByUserId(int userId)
        {
            return Task.Run(async () => await ApplicationDbContext.ElementUsers.Include(x=>x.AccordionElement).Where(x=>x.UserID_FK == userId).ToListAsync()).Result;
        }
    }
}