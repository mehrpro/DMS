using DMS.Entities;
using DMS.Repositories;
using StructureMap;
namespace DMS
{
    public class TypeRegister : Registry
    {
        public TypeRegister()
        {
            For<IUnitOfWork>().Use<UnitOfWork>();

        }
    }
}