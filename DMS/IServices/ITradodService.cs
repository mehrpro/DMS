using System;
using DMS.Entities;
using DMS.Repositories;

namespace DMS.IServices
{
    public interface ITradodService
    {
        //bool Send(Tradod model);
        bool Add(Tradod model);
    }

    public class TradodService : ITradodService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TradodService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //public bool Send(Tradod model)
        //{
        //    try
        //    {
                
        //        _unitOfWork.Tradod.Add(model);
        //        _unitOfWork.Commit();
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }
        //}

        public bool Add(Tradod model)
        {
            try
            {
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