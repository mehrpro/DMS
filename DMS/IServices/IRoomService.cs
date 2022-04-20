using DMS.Repositories;

namespace DMS.IServices
{
    public interface IRoomService
    {

    }

    public class RoomService : IRoomService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoomService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}