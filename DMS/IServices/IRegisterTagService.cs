using DMS.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DMS.Entities;

namespace DMS.IServices
{
    public interface IRegisterTagService
    {
        bool Add(int studentId, int tagId);
        Task<IEnumerable<RegisterTag>> GetRegisterTagByStudentId(int studentId);
    }

    public class RegisterTagService : IRegisterTagService
    {
        private readonly IUnitOfWork _unitOfWork;
        public RegisterTagService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public bool Add(int studentId, int tagId)
        {
            try
            {
                var find = Task.Run(async () => await _unitOfWork.RegisterTag
                .FindAllByCondition(x => x.StudentID_FK == studentId)).Result;
                foreach (var item in find)
                {
                    item.IsActive = false;
                    var result = Task.Run(async () => await _unitOfWork.Tag.FindByIdAsync(item.TagID_FK)).Result;
                    result.IsDeleted = true;
                    result.IsUsed = false;
                }

                _unitOfWork.RegisterTag
                    .Add(new RegisterTag { StudentID_FK = studentId, TagID_FK = tagId, IsActive = true, });
                Task.Run(async () => await _unitOfWork.Tag.FindByIdAsync(tagId)).Result.IsUsed = true;
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<RegisterTag>> GetRegisterTagByStudentId(int studentId)
        {
            return await _unitOfWork.RegisterTag.GetRegisterTagByStudentId(studentId);
        }
    }
}
