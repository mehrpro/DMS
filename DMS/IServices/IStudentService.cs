using DMS.Entities;
using DMS.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DMS.IServices
{
    public interface IStudentService
    {
        Task<bool> Update(Student model);
        bool Add(Student model);
        Task<IEnumerable<Student>> StudentList();
    }

    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public StudentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Update(Student model)
        {
            try
            {
                var find = await _unitOfWork.Student.FindByIdAsync(model.StudentID);
                find.Birthday = model.Birthday;
                find.EducationalID_FK = model.EducationalID_FK;
                find.FatherName = model.FatherName;
                find.FatherTel = model.FatherTel;
                find.OtherName = model.OtherName;
                find.OtherTel = model.OtherTel;
                find.HomeTel = model.HomeTel;
                find.StudyID_FK = model.StudyID_FK;
                find.FullName = model.FullName;
                find.NationalCode = model.NationalCode;
                find.StudentCode = model.StudentCode;
                find.StudentTel = model.StudentTel;
                find.Img = model.Img;
                //_unitOfWork.Student.Update(model, model.StudentID);
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Add(Student model)
        {
            try
            {
                _unitOfWork.Student.Add(model);
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<IEnumerable<Student>> StudentList()
        {
            return await _unitOfWork.Student.FindAllAsync();
        }
    }
}