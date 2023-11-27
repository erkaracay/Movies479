#nullable disable
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities;

public class Genre : Record
{
    [StringLength(75)]
    public string Name  { get; set; }
    public List<Movie> Movies  { get; set; }
}
