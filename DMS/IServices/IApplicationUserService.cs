using System;
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
        Task<bool> AddUser(ApplicationUser model);
        Task<bool> UpdateUser(ApplicationUser model);
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

        public async Task<bool> AddUser(ApplicationUser model)
        {
            try
            {
                _unitOfWork.ApplicationUser.Add(model);
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool> UpdateUser(ApplicationUser model)
        {
            try
            {
                _unitOfWork.ApplicationUser.Update(model,model.UserID);
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}