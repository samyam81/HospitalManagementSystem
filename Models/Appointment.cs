namespace HospitalManagementSystem.Models
{
    public class Appointment : BaseEntity
    {
        public long PatientId { get; set; }
        public Patient Patient { get; set; }

        public long DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; } 
    }

}
