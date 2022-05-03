using DMS.Repositories;

namespace DMS.IServices
{
    public interface IAccordionElementService
    {

    }

    public class AccordionElementService : IAccordionElementService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AccordionElementService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}