using System.Collections.Generic;
using System.Threading.Tasks;
using DMS.Entities;
using DMS.Repositories;

namespace DMS.IServices
{
    public interface IApplicationUserService
    {
        Task<IEnumerable<ApplicationUser>> GetAllUser();
        Task<IEnumerable<AccessTable>> GetAccessList();
    }

    public class ApplicationUserService : IApplicationUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ApplicationUserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllUser()
        {
            return await _unitOfWork.ApplicationUser.GetAllUser();
        }

        public async Task<IEnumerable<AccessTable>> GetAccessList()
        {
            return await _unitOfWork.AccessTable.FindAllAsync();
        }
    }
}