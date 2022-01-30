using System.ComponentModel.DataAnnotations;

namespace CMS.Models
{
    public class Patient
    {
        [Key]
        [Display(Name ="Patient ID")]
        public int PatientID { get; set; }
        [Display(Name = "Patient Name")]
        public string? PatientName { get; set; }
        [Display(Name = "Address")]
        public string? PatientAddress { get; set; }
        [Display(Name = "Age")]
        public int PatientAge { get; set; }
        [Display(Name = "Gender")]
        public string? PatientGender { get; set; }
        [Display(Name = "PhoneNo")]
        public int PatientPhone { get; set; }

    }
}
