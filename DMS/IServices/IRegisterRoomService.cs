using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMS.Entities;
using DMS.Repositories;

namespace DMS.IServices
{
    public interface IRegisterRoomService
    {
        bool Add(RegisterRoom model);
        Task<bool> Update(RegisterRoom model);
        Task<IEnumerable<RegisterRoom>> GetAllList();
        Task<IEnumerable<RegisterRoom>> GetRegisterRoomByRoomID(int roomId);
        Task<int> MandehOtagh(int roomId);
        Task<RegisterRoom> GetRoomByStudentID(int studentId);


    }

    public class RegisterRoomService : IRegisterRoomService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RegisterRoomService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool Add(RegisterRoom model)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(RegisterRoom model)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RegisterRoom>> GetAllList()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RegisterRoom>> GetRegisterRoomByRoomID(int roomId)
        {
            return await _unitOfWork.RegisterRoom.GetRegisterRoomByRoomId(roomId);


        }

        public async Task<int> MandehOtagh(int roomId)
        {
            var sumOzv = await _unitOfWork.RegisterRoom.CountAsyncByCondition(x => x.RoomID_FK == roomId);
            var zarfit = await _unitOfWork.Room.FindByIdAsync(roomId);
            var result = zarfit.RoomCapacity - sumOzv;
            return result;


        }

        public async Task<RegisterRoom> GetRoomByStudentID(int studentId)
        {
            return await _unitOfWork.RegisterRoom.GetRoomByStudentID(studentId);
        }
    }
}