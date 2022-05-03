using DMS.Repositories;

namespace DMS.IServices
{
    public interface IElementUserService
    {

    }

    public class ElementUserService : IElementUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ElementUserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}