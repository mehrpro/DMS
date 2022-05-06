using System.Collections.Generic;
using System.Threading.Tasks;
using DMS.Entities;
using DMS.Repositories;

namespace DMS.IServices
{
    public interface IAccordionElementService
    {
        IEnumerable<AccordionElement> GetGroup();
    
    }

    public class AccordionElementService : IAccordionElementService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AccordionElementService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<AccordionElement> GetGroup()
        {
            return Task.Run(async () => await _unitOfWork.AccordionElement.FindAllAsync()).Result;
        }
    }
}