using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeManager.Models
{
    public class Experience
    {
        public Experience()
        {

        }
        [Key]
        public int Id { get; set; }

        //very important*****
        [ForeignKey("Resume")]
        public int ResumeId { get; set; }
        public virtual Resume Resume { get; set; }

        [DisplayName("Company Name")]
        [Required]
        public string CompanyName { get; set; }
        public string Designation { get; set; }
        [Required]
        public int YearsWorked { get; set; }

    }
}
