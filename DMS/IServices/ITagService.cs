using System.Collections.Generic;
using System.Threading.Tasks;
using DMS.Entities;
using DMS.Repositories;
using System.Linq;
using System.Data.Entity;

namespace DMS.IServices
{
    public interface ITagService
    {
        Task<IEnumerable<Tag>> GetTagsEnabled();

    }

    public class TagService : ITagService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TagService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Tag>> GetTagsEnabled()
        {
            return await _unitOfWork.Tag.FindAllByCondition(x => !x.IsDeleted && !x.IsUsed);
        }
    }
}