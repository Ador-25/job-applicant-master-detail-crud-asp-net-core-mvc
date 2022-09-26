using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeManager.Models
{
    public class Resume
    {
        [Key]
        public int ResumeId { get; set; }
        [Required]
        [StringLength(100)]
        [DisplayName("Name: ")]
        public string Name { get; set; }
        [Required]
        //[StringLength(10)]

        public Genders Gender { get; set; }
        [Required]
        [Range(25,55,ErrorMessage ="Age has to be within limit 25-55")]
        [DisplayName("Age in years:")]
        public int Age { get; set; }
        public string Qualification { get; set; }
        public int TotalExperience { get; set; }
        public string PhotoUrl { get; set; }
        [Required]
        [DisplayName("Profile Photo")]
        [NotMapped]
        public IFormFile ProfilePic { get; set; }

        //important***
        public virtual List<Experience> Experiences { get; set; }
        public Resume()
        {

        }
    }
    public enum Genders
    {
        male,
        female
    }
}
