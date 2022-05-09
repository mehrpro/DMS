using DMS.Entities;
using System;
using DMS.ServiceReference1;

namespace DMS.Repositories
{
    public interface IUnitOfWork : IDisposable
    {

        IApplicationUserRep ApplicationUser { get; }
        IDormitoryRep Dormitory { get; }
        IEducationalCenterRep EducationalCenter { get; }
        IPanelInfoRep PanelInfo { get; }
        IRegisterRoomRep RegisterRoom { get; }
        IRegisterTagRep RegisterTag { get; }
        IRoomRep Room { get; }
        IStudentRep Student { get; }
        IStudyRep Study { get; }
        ITagreciveRep Tagrecive { get; }
        ITagRep Tag { get; }
        ITrafficTypeRep TrafficType { get; }
        ITradodRep Tradod { get; }
        tsmsService TsmsService { get; }
        IDestinationRep Destination { get; }
        ICreditWarningRep CreditWarning { get; }
        IElementUserRep ElementUser { get; }
        IAccordionElementRep AccordionElement { get; }
        IAccessTableRep AccessTable { get; }
        IAppointmentRep Appointment { get; }
        IResourceRep Resource { get; }
        int Commit();
    }

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;
        private IApplicationUserRep _applicationUserRep;
        private IDormitoryRep _dormitoryRep;
        private IEducationalCenterRep _educationalCenterRep;
        private IPanelInfoRep _panelInfoRep;
        private IRegisterRoomRep _registerRoomRep;
        private IRegisterTagRep _registerTagRep;
        private IRoomRep _roomRep;
        private ITagRep _tag;
        private IStudentRep _student;
        private IStudyRep _studyRep;
        private ITagreciveRep _tagreciveRep;
        private ITrafficTypeRep _trafficTypeRep;
        private ITradodRep _tradodRep;
        private IDestinationRep _destination;
        private tsmsService _tsmsService;
        private ICreditWarningRep _creditWarning;
        private IAccordionElementRep _accordionElementRep;
        private IElementUserRep _elementUserRep;
        private IAccessTableRep _accessTable;
        private IAppointmentRep _appointmentRep;
        private IResourceRep _resourceRep;
        private bool _disposed;


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }


        public IStudentRep Student => _student ??= new StudentRep(_context);
        public IApplicationUserRep ApplicationUser => _applicationUserRep ??= new ApplicationUserRep(_context);
        public IDormitoryRep Dormitory => _dormitoryRep ??= new DormitoryRep(_context);
        public IEducationalCenterRep EducationalCenter => _educationalCenterRep ??= new EducationalCenterRep(_context);
        public IPanelInfoRep PanelInfo => _panelInfoRep ??= new PanelInfoRep(_context);
        public IRegisterRoomRep RegisterRoom => _registerRoomRep ??= new RegisterRoomRep(_context);
        public IRegisterTagRep RegisterTag => _registerTagRep ??= new RegisterTagRep(_context);
        public IRoomRep Room => _roomRep ??= new RoomRep(_context);
        public ITagRep Tag => _tag ??= new TagRep(_context);
        public IStudyRep Study => _studyRep ??= new StudyRep(_context);
        public ITagreciveRep Tagrecive => _tagreciveRep ??= new TagreciveRep(_context);
        public ITrafficTypeRep TrafficType => _trafficTypeRep ??= new TrafficTypeRep(_context);
        public ITradodRep Tradod => _tradodRep ??= new TradodRep(_context);
        public IDestinationRep Destination => _destination ??= new DestinationRep(_context);
        public tsmsService TsmsService => _tsmsService ??= new tsmsServiceClient();
        public ICreditWarningRep CreditWarning => _creditWarning ??= new CreditWarningRep(_context);
        public IAccordionElementRep AccordionElement => _accordionElementRep ??= new AccordionElementRep(_context);
        public IElementUserRep ElementUser => _elementUserRep ??= new ElementUserRep(_context);
        public IAccessTableRep AccessTable => _accessTable ??= new AccessTableRep(_context);
        public IAppointmentRep Appointment => _appointmentRep ??= new AppointmentRep(_context);
        public IResourceRep Resource => _resourceRep ??= new ResourceRep(_context);
        public int Commit()
        {
            return _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
