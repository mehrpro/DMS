using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DMS.Entities;
using DMS.Repositories;

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
        private readonly IMapper _mapper;

        public StudentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> Update(Student model)
        {
            try
            {
                var find = await _unitOfWork.Student.FindByIdAsync(model.StudentID);
                var resultMap = _mapper.Map<Student>(model);
                _unitOfWork.

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