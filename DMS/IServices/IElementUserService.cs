using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DMS.Entities;
using DMS.Repositories;

namespace DMS.IServices
{
    public interface IElementUserService
    {
        IEnumerable<ElementUser> GetCleamByUserId(int userId);
        bool AddOrUpdateCleam(List<ElementUser> elementUsers);
      
    }

    public class ElementUserService : IElementUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ElementUserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<ElementUser> GetCleamByUserId(int userId)
        {
            return _unitOfWork.ElementUser.GetCleamByUserId(userId);
        }

        public bool AddOrUpdateCleam(List<ElementUser> elementUsers)
        {
            try
            {
                var list = new List<ElementUser>();
                var userid = elementUsers[0].UserID_FK;
                foreach (var item in elementUsers)
                {
                    var find =  _unitOfWork.ElementUser.SingleDefault(x => x.AccordionID_FK == item.AccordionID_FK && x.UserID_FK == userid);
                    if (find == null)
                    {
                        var user = new ElementUser();
                        user.UserID_FK = userid;
                        user.AccordionID_FK = item.AccordionID_FK;
                        user.IsActive = item.IsActive;
                        list.Add(user);
                    }
                    else
                        find.IsActive = item.IsActive;
                }
                _unitOfWork.ElementUser.AddRange(list);
                _unitOfWork.Commit();
                return true;
            }
            catch(Exception exception)
            {
                return false;
            }

        }
    }
}