using DMS.Entities;
using DMS.IServices;
using DMS.Repositories;
using StructureMap;
namespace DMS
{
    public class TypeRegister : Registry
    {
        public TypeRegister()
        {
            For<IUnitOfWork>().Use<UnitOfWork>();
            For<IDormitoryService>().Use<DormitoryService>();
            For<IRoomService>().Use<RoomService>();
        }
    }
}