using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DMS.Entities;
using DMS.Repositories;

namespace DMS.IServices
{
    public interface IDormitoryService
    {
        bool AddDormitory(Dormitory model);
        Task<bool> Update(Dormitory model);
        Task<IEnumerable<Dormitory>> ListDormitory();
        Task<int> MandehKol(int dormitoryId);

    }

    public class DormitoryService : IDormitoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DormitoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool AddDormitory(Dormitory model)
        {
            try
            {
                _unitOfWork.Dormitory.Add(model);
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }


        }

        public async Task<bool> Update(Dormitory model)
        {
            try
            {
                var find = await _unitOfWork.Dormitory.FindByIdAsync(model.ID);
                find.DormitoryName = model.DormitoryName;
                find.Room = model.Room;
                find.Valence = model.Valence;
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<IEnumerable<Dormitory>> ListDormitory()
        {
            return await _unitOfWork.Dormitory.FindAllAsync();
        }

        public async Task<int> MandehKol(int dormitoryId)
        {
            var sums = await _unitOfWork.RegisterRoom.CountAsyncByCondition(x => x.Room.DormitoryID_FK == dormitoryId && x.IsActive);
            var zarfiat = await _unitOfWork.Dormitory.FindByIdAsync(dormitoryId);
            return zarfiat.Valence - sums;
        }
    }
}