using DMS.Entities;

namespace DMS.Repositories
{

    public interface IAppointmentRep : IRepository<Appointment>
    {

    }

    public class AppointmentRep : Repository<Appointment>, IAppointmentRep
    {
        public AppointmentRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }
}
