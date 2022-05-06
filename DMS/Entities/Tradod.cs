using System;

namespace DMS.Entities
{
    public class Tradod
    {
        public int ID { get; set; }

        public int StudentID_FK { get; set; }
        public Student Student { get; set; }

        public int TrfficTypeID_FK { get; set; }
        public TrafficType TrafficType { get; set; }

        public int DestinationID_FK { get; set; }
        public Destination Destination { get; set; }

        public DateTime OutTime { get; set; }
        public DateTime InCommingTime { get; set; }

        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }

        public int UserID_FK { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public bool SendSMS1 { get; set; }
        public string ReciverNumber1 { get; set; }
        public string Delivery1 { get; set; }

        public bool SendSMS2 { get; set; }
        public string ReciverNumber2 { get; set; }
        public string Delivery2 { get; set; }
    }
}