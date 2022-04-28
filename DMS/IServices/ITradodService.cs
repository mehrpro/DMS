using System;
using DMS.Entities;
using DMS.Repositories;

namespace DMS.IServices
{
    public interface ITradodService
    {
        bool Send(Tradod model);
    }

    public class TradodService : ITradodService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TradodService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool Send(Tradod model)
        {
            try
            {
                var
                _unitOfWork.Tradod.Add(model);
                _unitOfWork.Commit();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}