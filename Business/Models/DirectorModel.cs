#nullable disable

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
	public class DirectorModel
	{
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [DisplayName("Birth Date")]
        public DateTime? BirthDate { get; set; }

        [DisplayName("Retired")]
        public bool IsRetired { get; set; }

        [DisplayName("Retired")]
        public string IsRetiredOutput { get; set; }

        [DisplayName("Retired")]
        public string BirthDateOutput { get; set; }

        [DisplayName("Name")]
        public string NameOutput { get; set; }
    }
}

