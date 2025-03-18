namespace HospitalManagementSystem.Models
{
    public class Doctor : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialization { get; set; }
        public string ContactNumber { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }

}
