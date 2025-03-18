namespace HospitalManagementSystem.Models
{
    public class MedicalRecord : BaseEntity
    {
        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        public string Diagnosis { get; set; }
        public string Prescription { get; set; }
        public DateTime RecordDate { get; set; }
    }

}
