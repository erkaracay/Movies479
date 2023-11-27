#nullable disable
using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
	public class MovieModel
	{
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        public short? Year { get; set; }

        public double Revenue { get; set; }

        public int? DirectorId { get; set; }

        public int Guid { get; set; }
    }
}

