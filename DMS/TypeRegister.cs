using System;
using System.Linq;
using AutoMapper;
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

            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(typeof(AutoMapperProfile));
            });
            var mapper = mapperConfiguration.CreateMapper();
            For<IMapper>().Use(mapper);
            //For<IMapper>().Use<Mapper>();


            For<IUnitOfWork>().Use<UnitOfWork>();
            For<IDormitoryService>().Use<DormitoryService>();
            For<IRoomService>().Use<RoomService>();
            For<ITrafficTypeService>().Use<TrafficTypeService>();
            For<IEducationalCenterService>().Use<EducationalCenterService>();
            For<IFieldOfStudyService>().Use<FieldOfStudyService>();
            For<IStudentService>().Use<StudentService>();
            For<IRegisterRoomService>().Use<RegisterRoomService>();
            For<IRegisterTagService>().Use<RegisterTagService>();
            For<ITagService>().Use<TagService>();
            For<ITradodService>().Use<TradodService>();
            For<ITrafficTypeService>().Use<TrafficTypeService>();
            For<IDestinationService>().Use<DestinationService>();
            For<ISmsService>().Use<SmsService>();
            For<IAccordionElementService>().Use<AccordionElementService>();
            For<IElementUserService>().Use<ElementUserService>();
            For<IApplicationUserService>().Use<ApplicationUserService>();
            For<IAppointmentService>().Use<AppointmentService>();
            For<IResourceService>().Use<ResourceService>();


        }
    }
}