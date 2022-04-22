using DMS.Entities;
using DMS.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DMS.IServices
{
    public interface ITrafficTypeService
    {
        Task<IEnumerable<TrafficType>> TrafficTypeList();
        Task<bool> Update(TrafficType model);
        bool Add(TrafficType model);
    }

    public class TrafficTypeService : ITrafficTypeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TrafficTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<TrafficType>> TrafficTypeList()
        {
            return await _unitOfWork.TrafficType.FindAllAsync();
        }

        public async Task<bool> Update(TrafficType model)
        {
            try
            {
                var find = await _unitOfWork.TrafficType.FindByIdAsync(model.ID);
                find.TrafficTypeTitle = model.TrafficTypeTitle;
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Add(TrafficType model)
        {
            try
            {
                _unitOfWork.TrafficType.Add(model);
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