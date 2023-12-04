#nullable disable
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities;

public class Genre : Record
{
    [StringLength(75)]
    public string Name  { get; set; }
    public List<MovieGenre> MovieGenres { get; set; }
}
