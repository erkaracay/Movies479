﻿#nullable disable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities;

public class MovieGenre : Record
{
    [Key]
    [Column(Order = 0)]
    public int MovieId  { get; set; }
    public Movie Movie  { get; set; }
    [Key]
    [Column(Order = 1)]
    public int GenreId  { get; set; }
    public Genre Genre  { get; set; }

}
