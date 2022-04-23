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
        Task<bool> RemoveStudentFromRoom(int registerRoomId);
        RegisterRoom GetRegisterRoomByStudentId(int studentId);


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
            try
            {
                _unitOfWork.RegisterRoom.Add(model);
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
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
            var sumOzv = await _unitOfWork.RegisterRoom.CountAsyncByCondition(x => x.RoomID_FK == roomId && x.IsActive);
            var zarfit = await _unitOfWork.Room.FindByIdAsync(roomId);
            var result = zarfit.RoomCapacity - sumOzv;
            return result;


        }

        public async Task<RegisterRoom> GetRoomByStudentID(int studentId)
        {
            return await _unitOfWork.RegisterRoom.GetRoomByStudentID(studentId);
        }

        public async Task<bool> RemoveStudentFromRoom(int registerRoomId)
        {
            try
            {
                var find = await _unitOfWork.RegisterRoom.FindAllByCondition(x=>x.StudentID_FK == registerRoomId);
                foreach (var item in find.ToList())
                {
                    item.IsActive = false;
                } 
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public RegisterRoom GetRegisterRoomByStudentId(int studentId)
        {
            return  _unitOfWork.RegisterRoom.GetRegisterRoomByStudentId(studentId);
        }
    }
}