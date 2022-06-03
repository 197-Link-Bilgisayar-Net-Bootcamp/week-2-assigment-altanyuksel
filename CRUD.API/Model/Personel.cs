using CRUD.API.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.API.Model {
  [Table(nameof(Personel))]
  public class Personel : IEntity{
    public int Id { get; set; }
    [Required]
    [StringLength(60)]
    public string Name { get; set; }
    [Required]
    [StringLength(60)]
    public string Surname { get; set; }

    [Required]
    [StringLength(30)]
    public string Sbn { get; set; }

    [Required]
    public int CountryId { get; set; }

    [DataType(DataType.Date)]
    public DateTime BirthDate { get; set; }
  }
}
