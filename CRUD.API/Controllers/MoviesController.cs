using CRUD.API.Data;
using CRUD.API.Data.EFCore;
using CRUD.API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD.API.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class MoviesController : MyMDBController<Movie, EfCoreMovieRepository> {
    public MoviesController(EfCoreMovieRepository repository) : base(repository) {

    }
  }
}
