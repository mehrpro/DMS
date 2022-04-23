using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DMS.Entities;
namespace DMS.Repositories
{
    public interface IRegisterRoomRep : IRepository<RegisterRoom>
    {
        Task<IEnumerable<RegisterRoom>> GetRegisterRoomByRoomId(int roomId);
        Task<RegisterRoom> GetRoomByStudentID(int studentId);

    }

    public class RegisterRoomRep : Repository<RegisterRoom>, IRegisterRoomRep
    {
        public RegisterRoomRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }

        public async Task<IEnumerable<RegisterRoom>> GetRegisterRoomByRoomId(int roomId)
        {
            return await ApplicationDbContext.RegisterRooms.Include(x => x.Room).Include(x => x.Student).Where(x => x.RoomID_FK == roomId).ToListAsync();
        }

        public async Task<RegisterRoom> GetRoomByStudentID(int studentId)
        {
            return await ApplicationDbContext.RegisterRooms.Include(x => x.Room).FirstOrDefaultAsync(x => x.StudentID_FK == studentId && x.IsActive);
        }
    }
}