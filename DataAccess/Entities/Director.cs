#nullable disable
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities;

public class Director : Record
{
    [StringLength(50)]
    public string Name { get; set; }

    [StringLength(50)]
    public string Surname { get; set; }

    public DateTime? BirthDate { get; set; }

    public bool IsRetired { get; set; }

    public List<Movie> Movies { get; set; }
}
