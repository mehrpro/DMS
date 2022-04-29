using System.Data.Entity;
using System.Threading.Tasks;
using System.Linq;
using DMS.Entities;
namespace DMS.Repositories
{
    public interface IPanelInfoRep : IRepository<PanelInfo>
    {
        Task<PanelInfo?> FirstRecorder();
        string[] WarningReceiver();
        int MinCredit();
        int MidCredit();
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

        public async Task<PanelInfo?> FirstRecorder()
        {
            return await ApplicationDbContext.PanelInfos.FirstOrDefaultAsync(x => x.IsActive);
        }

        public string[] SendNumber()
        {
            var result = ApplicationDbContext.PanelInfos.FirstOrDefault();
            return result == null ? new[] { "Error" } : new[] { result.SendNumber };
        }

        public string[] WarningReceiver()
        {
            var result = ApplicationDbContext.PanelInfos.FirstOrDefault();
            return result == null ? new[] { "Error" } : new[] { result.WarningReceiver };
        }

        public int MinCredit()
        {
            var result = ApplicationDbContext.PanelInfos.FirstOrDefault();
            return result == null ? 0 : result.MinCredit;
        }

        public int MidCredit()
        {
            var result = ApplicationDbContext.PanelInfos.FirstOrDefault();
            return result == null ? 0 : result.MidCredit;
        }
    }
}