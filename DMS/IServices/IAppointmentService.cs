using DMS.Repositories;

namespace DMS.IServices
{
    public interface IAppointmentService
    {

    }

    public class AppointmentService : IAppointmentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AppointmentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}