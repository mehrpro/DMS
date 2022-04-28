using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using DevExpress.Data.ODataLinq.Helpers;
using DMS.Entities;
namespace DMS.Repositories
{
    public interface IRegisterTagRep : IRepository<RegisterTag>
    {
        Task<IEnumerable<RegisterTag>> GetRegisterTagByStudentId(int studentId);
    }

    public class RegisterTagRep : Repository<RegisterTag>, IRegisterTagRep
    {
        public RegisterTagRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }

        public async Task<IEnumerable<RegisterTag>> GetRegisterTagByStudentId(int studentId)
        {
            return await ApplicationDbContext.RegisterTags.Include(x => x.Tag).Where(x => x.StudentID_FK == studentId).ToListAsync();

        }
    }
}