using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Models
{
    public class Doctor
    {
        [Key]
        [Display(Name = "Doctor ID")]
        public int DoctorID { get; set; }
        [Display(Name = "Doctor Name")]
        public string? DoctorName { get; set; }
        [Display(Name = "Address")]
        public string? DoctorAddress { get; set; }
        [Display(Name = "Age")]
        public int DoctorAge { get; set; }
        [Display(Name = "Gender")]
        public string? DoctorGender { get; set; }
        [Display(Name = "PhoneNo")]
        [Column(TypeName = "char(10)")]
        public string? DoctorPhone { get; set; }
        [Display(Name = "Qualification")]
        [Column(TypeName = "varchar(50)")]
        public string? Qualification { get; set; }
        [Display(Name = "Specialization")]
        [Column(TypeName = "varchar(50)")]
        public string? Specialization { get; set; }
        [Display(Name = "Charges")]
        public int Charges { get; set; }
    }
}
