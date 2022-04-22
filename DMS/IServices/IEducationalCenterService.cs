using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DMS.Entities;
using DMS.Repositories;

namespace DMS.IServices
{
    public interface IEducationalCenterService
    {
        bool Add(EducationalCenter model);
        Task<bool> Update(EducationalCenter model);
        Task<IEnumerable<EducationalCenter>> EducationalCenterList();
    }

    public class EducationalCenterService : IEducationalCenterService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EducationalCenterService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool Add(EducationalCenter model)
        {
            try
            {
                _unitOfWork.EducationalCenter.Add(model);
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool> Update(EducationalCenter model)
        {
            try
            {
                var find = await _unitOfWork.EducationalCenter.FindByIdAsync(model.ID);
                find.EducationalName = model.EducationalName;
                find.IsActive = model.IsActive;
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<IEnumerable<EducationalCenter>> EducationalCenterList()
        {
            return await _unitOfWork.EducationalCenter.FindAllAsync();
        }
    }
}