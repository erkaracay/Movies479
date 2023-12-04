#nullable disable
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
	public class MovieModel
	{
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        public short? Year { get; set; }

        public double Revenue { get; set; }

        [DisplayName("Director")]
        public int? DirectorId { get; set; }

        [DisplayName("Director")]
        public string DirectorOutput { get; set; }
    }
}

