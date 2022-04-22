using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DMS.Entities;
using DMS.Repositories;

namespace DMS.IServices
{
    public interface IFieldOfStudyService
    {
        Task<bool> Update(Study model);
        bool Add(Study model);
        Task<IEnumerable<Study>> StudyList();
    }

    public class FieldOfStudyService : IFieldOfStudyService
    {
        private readonly IUnitOfWork _unitOfWork;

        public FieldOfStudyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Update(Study model)
        {
            try
            {
                var find = await _unitOfWork.Study.FindByIdAsync(model.ID);
                find.IsActive = model.IsActive;
                find.StudyTitle = model.StudyTitle;
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Add(Study model)
        {
            try
            {
                _unitOfWork.Study.Add(model);
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<IEnumerable<Study>> StudyList()
        {
            return await _unitOfWork.Study.FindAllAsync();
        }
    }
}