using CRUD.API.Data.EFCore;
using CRUD.API.Model;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.API.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class PersonelController : MyMDBController<Personel, EfCorePersonelRepository> {
    public PersonelController(EfCorePersonelRepository repository) : base(repository) {

    }
  }
}