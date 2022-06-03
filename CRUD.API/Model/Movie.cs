using CRUD.API.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.API.Model {
  [Table(nameof(Movie))]
  public class Movie : IEntity {
    public int Id { get; set; }

    [Required]
    [StringLength(60)]
    public string Title { get; set; }

    [Required]
    [StringLength(30)]
    public string Genre { get; set; }

    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
  }
}
