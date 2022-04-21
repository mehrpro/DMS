using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DMS.Entities;
using DMS.Repositories;

namespace DMS.IServices
{
    public interface IRoomService
    {
        Task<IEnumerable<Room>> GetRoomByDormitoryID(int dormitoryId);
        bool Add(Room model);
        Task<bool> Update(Room model);
    }

    public class RoomService : IRoomService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RoomService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Room>> GetRoomByDormitoryID(int dormitoryId)
        {
            return await _unitOfWork.Room.FindAllByCondition(x => x.DormitoryID_FK == dormitoryId);
        }

        public bool Add(Room model)
        {
            try
            {
                _unitOfWork.Room.Add(model);
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool> Update(Room model)
        {
            try
            {
                var find = await _unitOfWork.Room.FindByIdAsync(model.RoomID);
                find.RoomCapacity = model.RoomCapacity;
                find.RoomNumber = model.RoomNumber;
                find.DormitoryID_FK = model.DormitoryID_FK;
                find.Facilities = model.Facilities;
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