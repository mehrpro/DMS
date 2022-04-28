using System.Collections.Generic;
using System.Threading.Tasks;
using DMS.Entities;
using DMS.Repositories;

namespace DMS.IServices
{
    public interface IDestinationService
    {
        Task<IEnumerable<Destination>> GetDestinationList();
    }

    public class DestinationService : IDestinationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DestinationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Destination>> GetDestinationList()
        {
            return await _unitOfWork.Destination.FindAllAsync();
        }
    }
}