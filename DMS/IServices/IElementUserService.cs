using System.Collections.Generic;
using System.Threading.Tasks;
using DMS.Entities;
using DMS.Repositories;

namespace DMS.IServices
{
    public interface IElementUserService
    {
        IEnumerable<ElementUser> GetCleamByUserId(int userId);
        
    }

    public class ElementUserService : IElementUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ElementUserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<ElementUser> GetCleamByUserId(int userId)
        {
            return Task.Run(async () => await _unitOfWork.ElementUser.FindAllByCondition(x => x.UserID_FK == userId)).Result;
        }
    }
}