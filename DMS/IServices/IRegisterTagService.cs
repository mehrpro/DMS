using DMS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.IServices
{
    public interface IRegisterTagService
    {
        bool Add(int studentId, int tagId);
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
                _unitOfWork.RegisterTag.Add(new Entities.RegisterTag() { StudentID_FK = studentId, TagID_FK = tagId,IsActive =true,})
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
