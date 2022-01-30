using System.ComponentModel.DataAnnotations;

namespace CMS.Models
{
    public class Appointment
    {
        [Key]
        public int AppointID { get; set; }
        public int DoctorID { get; set; }
        public int PatientID { get; set; }
        public DateTime Date { get; set; }=DateTime.Now;
        public int Appointment_Status{ get; set; }
        public float BillAmount { get; set; }
        public string? BillStatus { get; set; }
        public int DoctorNotification { get; set; }
        public int PatientNotification { get; set; }
        public int FeedbackStatus { get; set; }
        public string? Disease { get; set; }
        public string? Progress { get; set; }
        public string? Prescription { get; set; }
    }
}
