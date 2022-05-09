using DMS.Repositories;

namespace DMS.IServices
{
    public interface IResourceService
    {
        
    }

    public class ResourceService : IResourceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ResourceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}