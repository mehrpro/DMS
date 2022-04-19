using DMS.Entities;
namespace DMS.Repositories
{
    public interface IPanelInfoRep : IRepository<PanelInfo>
    {

    }

    public class PanelInfoRep : Repository<PanelInfo>, IPanelInfoRep
    {
        public PanelInfoRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }
}