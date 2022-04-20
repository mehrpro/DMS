using DMS.Entities;
using System;

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

        int Commit();
    }

    public class UnitOfWork : IUnitOfWork
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

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
